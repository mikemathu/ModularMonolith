using Api.Models;
using Integration.UserManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsers users;

        public HomeController(IUsers users)
        {
            this.users = users;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            var user = await users.WithId(1);

            /* return user == null ? NotFound() : Ok(user);*/

           /* UserVMList usersList = new UserVMList()
            {
                UsersList = (IEnumerable<UserVM>)user
            };*/

            return View(user);

        }
    }
}
