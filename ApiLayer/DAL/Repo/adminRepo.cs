using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class adminRepo : iRepository<admin, int>
    {
        FundUser_Entities db;
        public adminRepo(FundUser_Entities db)
        {
            this.db = db;
        }
        public void Add(admin e)
        {
            db.admins.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.admins.FirstOrDefault(e => e.id == id);
            db.admins.Remove(s);
            db.SaveChanges();
        }

        public void Edit(admin e)
        {
            var s = db.admins.FirstOrDefault(es => es.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<admin> Get()
        {
            return db.admins.ToList();
        }

        public admin Get(int id)
        {
            var ds = db.admins.FirstOrDefault(s => s.id == id);
            return ds;
        }
    }
}
