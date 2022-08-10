using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class userRepo : iRepository<user, int>
    {
        FundUser_Entities db;
        public userRepo(FundUser_Entities db)
        {
            this.db = db;
        }
        public void Add(user e)
        {
            db.users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.users.FirstOrDefault(e => e.Id == id);
            db.users.Remove(s);
            db.SaveChanges();
        }

        public void Edit(user e)
        {
            var s = db.users.FirstOrDefault(es => es.Id == e.Id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<user> Get()
        {
            return db.users.ToList();
        }

        public user Get(int id)
        {
            var ds = db.users.FirstOrDefault(s => s.Id == id);
            return ds;
        }
    }
}
