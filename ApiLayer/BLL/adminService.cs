using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;


namespace BLL
{
    public class adminService
    {
        public static List<adminModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<admin, adminModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.StudentDataAccess();
            //var data = mapper.Map<List<StudentModel>>(da.Get());

            var data = mapper.Map<List<adminModel>>(DataAccessFactory.AdminDataAccess().Get());
            return data;


        }
        public static List<string> GetNames()
        {
            var data = DataAccessFactory.AdminDataAccess().Get().Select(e => e.Name).ToList();
            //var sl = StudentRepo.Get();
            //var data = (from v in sl select v.Name).ToList();
            return data;
        }
        public static void Add(adminModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<adminModel, admin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<admin>(s);
            DataAccessFactory.AdminDataAccess().Add(data);
        }


        //edit delete

        public static void Delete(int id)
        {
            DataAccessFactory.AdminDataAccess().Delete(id);
        }
        //public static admin Edit(int id)
        //{
        //    return adminRepo.Edit(id);
        //}

        //Edit here 
        public static void Edit(adminModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<adminModel, admin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<admin>(s);
            DataAccessFactory.AdminDataAccess().Edit(data);
        }


    }
}
