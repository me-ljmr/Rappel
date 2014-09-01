using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Rappel.DataAccess
{
    public class ListActionsActivities
    {
        public DataTable GetListingActions()
        {
            string sqltext = string.Empty;
            sqltext = "select * from listingactions order by sort_order";
            return DatabaseLibrary.GetRecordset(sqltext, null);
        }
    }
}
