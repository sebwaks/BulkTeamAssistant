using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox;
using Microsoft.Crm.Sdk.Messages;
using Bulk_Team_Assistant.AppCode;
using Microsoft.Xrm.Sdk;
using System.Threading;
using Microsoft.Xrm.Sdk.Messages;

namespace Bulk_Team_Assistant
{
    public partial class TeamAssistantMain : PluginBase
    {


        private static bool usersSelected = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAssistantMain"/> class.
        /// </summary>
        public TeamAssistantMain()
        {
            InitializeComponent();
            teamTypeComboBox.SelectedIndex = 0;
            comboBoxUsersViews.SelectedIndex = 0;
        }


        /// <summary>
        /// Gets the plugin logo.
        /// </summary>
        /// <value>
        /// The plugin logo.
        /// </value>
        public override Image PluginLogo
        {

            get { return Bulk_Team_Assistant.Properties.Resources.Logo; }
        }

        /// <summary>
        /// Closings the plugin.
        /// </summary>
        /// <param name="info">The information.</param>
        public override void ClosingPlugin(PluginCloseInfo info)
        {
            if (info.FormReason != CloseReason.None ||
                info.ToolBoxReason == ToolBoxCloseReason.CloseAll ||
                info.ToolBoxReason == ToolBoxCloseReason.CloseAllExceptActive)
            {
                return;
            }

            info.Cancel = MessageBox.Show(@"Are you sure you want to close this tab?", @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }


        /// <summary>
        /// Handles the Click event of the closeButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            base.CloseTool();
        }


        /// <summary>
        /// Handles the Click event of the loadTeamsAndUsersButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void loadTeamsAndUsersButton_Click(object sender, EventArgs e)
        {
            listViewTeams.Items.Clear();
            listViewUsers.Items.Clear();
            logBox.Clear();
            ExecuteMethod(RefreshTeams);

        }


        /// <summary>
        /// Handles the Click event of the toolStripAddSelectedUsersToTeams control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripAddSelectedUsersToTeams_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(string.Format("Are you sure you want to add {0} selected users to selected access teams ", listViewUsers.CheckedItems.Count), @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No;
            if (confirm)
            {
                ExecuteMethod(ProcessAddSelectedUsersToTeams);
            }
        }

        private void removeSelectedUsersMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(string.Format("Are you sure you want to remove {0} selected users from selected access teams ", listViewUsers.CheckedItems.Count), @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No;
            if (confirm)
            {
                ExecuteMethod(ProcessRemoveSelectedUsersFromTeams);
            }
        }

        /// <summary>
        /// Processes the remove selected users from teams.
        /// </summary>
        private void ProcessRemoveSelectedUsersFromTeams()
        {

            WorkAsync("Removing selected users from selected teams(s)...",
               (bw, evt) =>
               {
                   var selectedTeams = listViewTeams.CheckedItems.Cast<ListViewItem>().Select(cT => (Entity)cT.Tag).ToList();
                   var selectedUsers = listViewUsers.CheckedItems.Cast<ListViewItem>().Select(cU => (Entity)cU.Tag).ToList();

                   var teamManager = new TeamUsersManager(Service);
                   var result = teamManager.ExecuteAddRemoveUsersToTeam(selectedTeams, selectedUsers, OperationType.RemoveUser);
                   DisplayResponses(result);


                   bw.ReportProgress(99, "Finishing");
               },
               evt =>
               {
                   if (evt.Error != null)
                   {
                       MessageBox.Show(this, "An error occured: " + evt.Error.Message, "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                   }
               },
               evt => SetWorkingMessage(string.Format(evt.UserState.ToString())));

        }


        /// <summary>
        /// Processes the add selected users to teams.
        /// </summary>
        private void ProcessAddSelectedUsersToTeams()
        {
           
            WorkAsync("Adding selected users to selected teams(s)...",
               (bw, evt) =>
               {
                   var selectedTeams = listViewTeams.CheckedItems.Cast<ListViewItem>().Select(cT => (Entity)cT.Tag).ToList();
                   var selectedUsers = listViewUsers.CheckedItems.Cast<ListViewItem>().Select(cU => (Entity)cU.Tag).ToList();

                   var teamManager = new TeamUsersManager(Service);
                   var result = teamManager.ExecuteAddRemoveUsersToTeam(selectedTeams, selectedUsers, OperationType.AddUsers);
                   DisplayResponses(result);


                   bw.ReportProgress(99, "Finishing");
               },
               evt =>
               {
                   if (evt.Error != null)
                   {
                       MessageBox.Show(this, "An error occured: " + evt.Error.Message, "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                   }
               },
               evt => SetWorkingMessage(string.Format(evt.UserState.ToString())));

        }


        /// <summary>
        /// Displas the responses.
        /// </summary>
        /// <param name="responses">The responses.</param>
        public void DisplayResponses(List<ExecuteMultipleResponse> responses)
        {
            logBox.Clear();
            foreach (var resultitem in responses)
            {
                foreach (var responseItem in resultitem.Responses)
                {
                    if (responseItem.Fault != null)
                    {

                        logBox.AppendText(string.Format("ERROR Details: {0}", responseItem.Fault.Message + Environment.NewLine));
                    }
                    else
                    {

                        logBox.AppendText(string.Format("Sucess", Environment.NewLine));
                    }
                }
            }


        }

        /// <summary>
        /// Refreshes the teams.
        /// </summary>
        private void RefreshTeams()
        {
            WorkAsync("Retrieving Owner Teams and Users....",
                (e) => // Work To Do Asynchronously
                {
                    var teamType = teamTypeComboBox.SelectedIndex;
                    var teamManager = new TeamUsersManager(Service);
                    var allownerTeams = teamManager.GetTeams(teamType).Entities;
                    listViewTeams.Items.AddRange(allownerTeams.Select(team => new ListViewItem
                    {

                        Text = team.Attributes["name"].ToString(),
                        SubItems =
                            {
                            team.GetAttributeValue<EntityReference>("businessunitid").Name,                          
                    
                            },
                        ImageIndex = 0,
                        StateImageIndex = 0,
                        Tag = team
                    }
                    ).ToArray());
                    noTeamsLabel.Text = string.Format("Total teams {0}", listViewTeams.Items.Count);


                    var enabledUsers = teamManager.GetEnabledUsers().Entities;
                    listViewUsers.Items.AddRange(enabledUsers.Select(user => new ListViewItem
                    {
                        Text = user.Attributes["fullname"].ToString(),
                        SubItems =
                            {
                            user.GetAttributeValue<EntityReference>("businessunitid").Name,                          
                    
                            },
                        ImageIndex = 0,
                        StateImageIndex = 0,
                        Tag = user

                    }).ToArray());




                },
                e =>  // Cleanup when work has completed
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(this, "An error occured: " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            );
        }



        /// <summary>
        /// Handles the ItemChecked event of the userslistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemCheckedEventArgs"/> instance containing the event data.</param>
        private void userslistView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            lblSelectedUsers.Text = string.Format("{0} Selected  user(s)", listViewUsers.CheckedItems.Count);
        }

        /// <summary>
        /// Handles the ItemChecked event of the listViewTeams control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemCheckedEventArgs"/> instance containing the event data.</param>
        private void listViewTeams_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            lblSelectedTeams.Text = string.Format("{0} Selected  team(s)", listViewTeams.CheckedItems.Count);
        }

        /// <summary>
        /// Handles the KeyDown event of the listViewUsers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void listViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {

                WorkAsync(" (Un)Selecting...... ",
                  (evt) =>
                  {

                      usersSelected = !usersSelected;
                      ListViewHelper.CheckAllItems(listViewUsers, usersSelected);

                  },
                   evt =>
                   {
                       if (evt.Error != null)
                       {
                           MessageBox.Show(this, "An error occured: " + evt.Error.Message, "Error", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                       }
                   });

            }
        }












    }
}
