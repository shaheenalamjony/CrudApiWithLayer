using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class adminRepo
    {
        static FundUserEntities db;
        static adminRepo()
        {
            db = new FundUserEntities();
        }

        public static List<admin> Get()
        {
            return db.admins.ToList();
        }

        public static admin Get(int id)
        {
            return db.admins.FirstOrDefault(x => x.id == id);
        }

        //public static admin Edit(int id)
        //{
        //    var ds = db.admins.FirstOrDefault(e => e.id == id);

        //    return ds;
        //}


        public static void Edit(admin s)
        {
            var ds = db.admins.FirstOrDefault(e => e.id == s.id);
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            var ds = db.admins.FirstOrDefault(e => e.id == id);
            db.admins.Remove(ds);
            db.SaveChanges();
        }
        

        public static void Add(admin a)
        {
            db.admins.Add(a);
            db.SaveChanges();
        }

    }
}
