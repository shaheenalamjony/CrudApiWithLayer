using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class employeeRepo : iRepository<employee, int>
    {
        FundUser_Entities db;
        public employeeRepo(FundUser_Entities db)
        {
            this.db = db;
        }
        public void Add(employee e)
        {
            db.employees.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.employees.FirstOrDefault(e => e.Id == id);
            db.employees.Remove(s);
            db.SaveChanges();
        }

        public void Edit(employee e)
        {
            var s = db.employees.FirstOrDefault(es => es.Id == e.Id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<employee> Get()
        {
            return db.employees.ToList();
        }

        public employee Get(int id)
        {
            var ds = db.employees.FirstOrDefault(s => s.Id == id);
            return ds;
        }
    }
}
