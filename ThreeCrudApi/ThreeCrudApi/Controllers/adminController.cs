using BLL;
using BLL.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ThreeCrudApi.Controllers
{
    public class adminController : ApiController
    {
        [Route("api/admin/all")]
        [HttpGet]
        public List<adminModel> GetAll()
        {
            return adminService.Get();
        }

        [Route("api/admin/names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return adminService.GetNames();

        }

        [Route("api/admin/create")]
        [HttpPost]

        public void Add(adminModel s)
        {
            adminService.Add(s);
        }

        [Route("api/admin/delete/{id}")]
        [HttpDelete]

        public void Delete(int id)
        {

            adminService.Delete(id);
        }
        //[Route("api/admin/Edit/{id}")]
        //[HttpPost]
        //public void Edit(int id)
        //{
        //    adminService.Edit(id);
        //}

        //Edit here
        [Route("api/admin/Edit")]
        [HttpPost]

        public void Edit(adminModel s)
        {
            adminService.Edit(s);
        }


    }
}
