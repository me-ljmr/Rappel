using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Rappel.DataStructure ;
namespace Rappel.BusinessLogic
{
    public class ListsLogic
    {
        Rappel.DataAccess.ListsActivities bga = new DataAccess.ListsActivities();
        public string ErrMessage { get; set; }
        public List<Lists> ListColl()
        {
            return bga.ListCollection;
        }
        public DataTable GetLists()
        {
            return bga.GetLists();
        }

        public bool SaveLists(long listid,long sort_order, string listtitle)
        {
            bool result = false;
            try
            {
                result = bga.SaveLists(listid,sort_order,listtitle);
            }
            catch (Exception ex)
            {
                ErrMessage = ex.Message;
                result = false;
            }
            return result;

        }
        public bool SaveLists(string listtitle)
        {
            bool result = false ;
            try
            {
                result = bga.SaveLists(listtitle);
            }
            catch (Exception ex)
            {
                ErrMessage = ex.Message;
                result = false;
            }
            return result;
        }
    }
}
