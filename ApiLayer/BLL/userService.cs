using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class userService
    {
        public static List<userModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<user, userModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.StudentDataAccess();
            //var data = mapper.Map<List<StudentModel>>(da.Get());

            var data = mapper.Map<List<userModel>>(DataAccessFactory.UserDataAccess().Get());
            return data;


        }
        public static List<string> GetNames()
        {
            var data = DataAccessFactory.UserDataAccess().Get().Select(e => e.Name).ToList();
            //var sl = StudentRepo.Get();
            //var data = (from v in sl select v.Name).ToList();
            return data;
        }
        public static void Add(userModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<userModel, user>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<user>(s);
            DataAccessFactory.UserDataAccess().Add(data);
        }

        //edit delete

        public static void Delete(int id)
        {
            DataAccessFactory.UserDataAccess().Delete(id);
        }
        

        //Edit here 
        public static void Edit(userModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<userModel, user>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<user>(s);
            DataAccessFactory.UserDataAccess().Edit(data);
        }

    }
}
