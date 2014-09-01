using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Rappel.BusinessLogic
{
    public class ListingActionsLogic
    {
        Rappel.DataAccess.ListActionsActivities laa = new DataAccess.ListActionsActivities();
        public DataTable GetListingActions()
        {
            return laa.GetListingActions();
        }
    }
}
