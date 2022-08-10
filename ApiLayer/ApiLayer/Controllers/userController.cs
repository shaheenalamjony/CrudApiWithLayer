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
    public class userController : ApiController
    {
        [Route("api/user/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return userService.GetNames();

        }

        [Route("api/user/all")]
        [HttpGet]
        public List<userModel> GetAll()
        {
            return userService.Get();
        }

        [Route("api/user/create")]
        [HttpPost]

        public void Add(userModel s)
        {
            userService.Add(s);
        }

        [Route("api/user/delete/{id}")]
        [HttpDelete]

        public void Delete(int id)
        {

            userService.Delete(id);
        }
        //[Route("api/admin/Edit/{id}")]
        //[HttpPost]
        //public void Edit(int id)
        //{
        //    adminService.Edit(id);
        //}

        //Edit here
        [Route("api/user/Edit")]
        [HttpPost]

        public void Edit(userModel s)
        {
            userService.Edit(s);
        }

    }
}
