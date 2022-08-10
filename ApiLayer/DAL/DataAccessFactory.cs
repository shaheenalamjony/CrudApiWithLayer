using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static FundUser_Entities db;
        static DataAccessFactory()
        {
            db = new FundUser_Entities();
        }

        public static iRepository<admin, int> AdminDataAccess()
        {
            return new adminRepo(db);
        }

        public static iRepository<employee, int> EmployeeDataAccess()
        {
            return new employeeRepo(db);
        }

        public static iRepository<user, int> UserDataAccess()
        {
            return new userRepo(db);
        }
    }
}
