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
    public class employeeService
    {
        public static List<employeeModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<employee, employeeModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.StudentDataAccess();
            //var data = mapper.Map<List<StudentModel>>(da.Get());

            var data = mapper.Map<List<employeeModel>>(DataAccessFactory.EmployeeDataAccess().Get());
            return data;


        }
        public static List<string> GetNames()
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get().Select(e => e.Name).ToList();
            //var sl = StudentRepo.Get();
            //var data = (from v in sl select v.Name).ToList();
            return data;
        }
        public static void Add(employeeModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<employeeModel, employee>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<employee>(s);
            DataAccessFactory.EmployeeDataAccess().Add(data);
        }

        //edit delete

        public static void Delete(int id)
        {
            DataAccessFactory.EmployeeDataAccess().Delete(id);
        }
        

        //Edit here 
        public static void Edit(employeeModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<employeeModel, employee>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<employee>(s);
            DataAccessFactory.EmployeeDataAccess().Edit(data);
        }

    }
}
