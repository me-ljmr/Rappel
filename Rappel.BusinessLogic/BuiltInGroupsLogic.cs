using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Rappel.DataStructure;
namespace Rappel.BusinessLogic
{
    public class BuiltInGroupsLogic
    {
        Rappel.DataAccess.BuiltInGroupActivities bg = new DataAccess.BuiltInGroupActivities();
        public DataTable GetBuiltInGroups()
        {
            
            return bg.GetBuiltInGroups();
        }
        public List<BuiltInGroups> BuiltInGroupsCollection()
        {
            return bg.BuiltInGroupCollection;
        }
    }
}
