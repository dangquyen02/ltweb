using Dapper;
using SV20T1020237.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV20T1020237.DataLayers.SqlServer
{
    public class EmployeeAccountDAL : _BaseDAL, IUserAccountDAL
    {
        public EmployeeAccountDAL(string connectionString) : base(connectionString)
        {
        }

        public UserAccount? Authorize(string userName, string password)
        {
            UserAccount data;
            using (var cn = OpenConnection())
            {
                var sql = @"select EmployeeID as UserID, Email as UserName, FullName, Email, Photo, Password, RoleNames 
                           from Employees where Email=@Email AND Password=@Password";
                var parameters = new
                {
                    Email = userName,
                    Password = password,
                };
                data = cn.QuerySingleOrDefault<UserAccount>(sql, parameters);
                cn.Close();
            }
            return data;
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            bool result = false;
            using (var cn = OpenConnection())
            {
                var sql = @"update Employees 
                            set Password=@NewPassword 
                            where Email=@Email and Password=@OldPassword";
                var parameters = new
                {
                    Email = userName,
                    OldPassword = oldPassword,
                    NewPassword = newPassword
                };
                result = cn.Execute(sql, parameters) > 0;
                cn.Close();
            }
            return result;
        }

        public bool CheckPassword(string userName, string oldPassword)
        {
            bool result = false; // Ban đầu đặt result là false

            using (var cn = OpenConnection())
            {
                var sql = @"SELECT COUNT(*) FROM employees WHERE Email = @Email AND Password = @OldPassword";
                var parameters = new
                {
                    Email = userName,
                    OldPassword = oldPassword
                };
                int count = cn.ExecuteScalar<int>(sql, parameters);
                result = count > 0;
            }

            return result;
        }

    }
}
