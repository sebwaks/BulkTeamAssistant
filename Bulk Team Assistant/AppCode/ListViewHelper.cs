using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_Team_Assistant.AppCode
{
    public class ListViewHelper
    {

        public static void CheckAllItems(ListView lvw, bool check)
        {
            lvw.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = check);
        }
    }
}
