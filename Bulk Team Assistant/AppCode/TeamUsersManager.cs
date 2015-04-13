using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_Team_Assistant.AppCode
{
    public class TeamUsersManager
    {

        private readonly IOrganizationService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamUsersManager"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public TeamUsersManager(IOrganizationService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The get enabled users
        /// </summary>
        string getEnabledUsers = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false' no-lock='true'>
                                  <entity name='systemuser'>
                                    <attribute name='fullname' />
                                    <attribute name='businessunitid' />                                    
                                    <attribute name='systemuserid' />
                                    <order attribute='fullname' descending='false' />
                                    <filter type='and'>
                                      <condition attribute='isdisabled' operator='eq' value='0' />
                                    </filter>
                                  </entity>
                                </fetch>";

        /// <summary>
        /// The get team fetch XML
        /// </summary>
        string getTeamFetchXML = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false' no-lock='true'>
                                      <entity name='team'>
                                        <attribute name='name' />
                                        <attribute name='businessunitid' />
                                        <attribute name='teamid' />
                                        <attribute name='teamtype' />
                                        <order attribute='name' descending='false' />
                                        <filter type='and'>
                                          <condition attribute='teamtype' operator='eq' value='{0}' />
                                        </filter>
                                      </entity>
                                    </fetch>";


        /// <summary>
        /// Gets the teams.
        /// </summary>
        /// <param name="teamtype">The teamtype.</param>
        /// <returns></returns>
        public EntityCollection GetTeams(int teamtype)
        {
            return service.RetrieveMultiple(new FetchExpression(string.Format(getTeamFetchXML, teamtype)));
        }



        /// <summary>
        /// Gets the enabled users.
        /// </summary>
        /// <param name="teamtype">The teamtype.</param>
        /// <returns></returns>
        public EntityCollection GetEnabledUsers()
        {
            return service.RetrieveMultiple(new FetchExpression(getEnabledUsers));
        }


        /// <summary>
        /// Executes the add remove users to team.
        /// </summary>
        /// <param name="selectedTeams">The selected teams.</param>
        /// <param name="selectedUsers">The selected users.</param>
        /// <param name="operation">The operation.</param>
        /// <returns></returns>
        public List<ExecuteMultipleResponse> ExecuteAddRemoveUsersToTeam(List<Entity> selectedTeams, List<Entity> selectedUsers, OperationType operation)
        {
            var responses = new List<ExecuteMultipleResponse>();
            OrganizationRequestCollection requests = new OrganizationRequestCollection();

            foreach (var selectedteam in selectedTeams)
            {

                switch (operation)
                {

                    case OperationType.AddUsers:
                        requests.Add(new AddMembersTeamRequest { TeamId = selectedteam.Id, MemberIds = selectedUsers.Select(usr => usr.Id).ToArray() });
                        break;
                    case OperationType.RemoveUser:
                        requests.Add(new RemoveMembersTeamRequest { TeamId = selectedteam.Id, MemberIds = selectedUsers.Select(usr => usr.Id).ToArray() });
                        break;

                    default:
                        break;

                }

                var requestWithResults = new ExecuteMultipleRequest()
                {

                    Settings = new ExecuteMultipleSettings()
                    {
                        ContinueOnError = true,
                        ReturnResponses = true
                    },
                    // Create an empty organization request collection.
                    Requests = requests
                };

                ExecuteMultipleResponse responseWithResults = (ExecuteMultipleResponse)service.Execute(requestWithResults);

                responses.Add(responseWithResults);
            }

            return responses;

        }
    }
}
