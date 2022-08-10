using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiLayer.Controllers
{
    public class employeeController : ApiController
    {
        [Route("api/empolyee/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return employeeService.GetNames();

        }

        [Route("api/employee/all")]
        [HttpGet]
        public List<employeeModel> GetAll()
        {
            return employeeService.Get();
        }

        [Route("api/employee/create")]
        [HttpPost]

        public void Add(employeeModel s)
        {
            employeeService.Add(s);
        }

        [Route("api/employee/delete/{id}")]
        [HttpDelete]

        public void Delete(int id)
        {

            employeeService.Delete(id);
        }
        //[Route("api/admin/Edit/{id}")]
        //[HttpPost]
        //public void Edit(int id)
        //{
        //    adminService.Edit(id);
        //}

        //Edit here
        [Route("api/employee/Edit")]
        [HttpPost]

        public void Edit(employeeModel s)
        {
            employeeService.Edit(s);
        }
    }
}
