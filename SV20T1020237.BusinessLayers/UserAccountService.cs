
using SV20T1020237.BusinessLayers;
using SV20T1020237.DataLayers.SqlServer;
using SV20T1020237.DataLayers;
using SV20T1020237.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV20T1020237.BusinessLayers
{
    public static class UserAccountService
    {
        private static readonly IUserAccountDAL userAccountDB;
        //private static readonly IUserAccountDAL customerAccountDB;
        static UserAccountService()
        {
            string connectionString = Configuration.ConnectionString;
            userAccountDB = new EmployeeAccountDAL(connectionString);
            //customerAccountDB = new CustomerAccountDAL(connectionString);

        }
        public static UserAccount? Authorize(string userName, string password)
        {
            return userAccountDB.Authorize(userName, password);
        }
        public static bool ChangePassword(string userName, string oldPassword, string newPassword)
        {

            return userAccountDB.ChangePassword(userName, oldPassword, newPassword);

        }

        public static bool CheckPassword(string userName, string oldPassword)
        {

            return userAccountDB.CheckPassword(userName, oldPassword);

        }
    }
}