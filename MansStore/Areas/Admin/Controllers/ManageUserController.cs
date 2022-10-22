using BissnessEntity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BissenessLagicLayer;
namespace MansStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManageUserController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private UserManager<UserApp> userManager;
       
        public ManageUserController(UserManager<UserApp> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;        

            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var model = userManager.Users.Select(i => new Models.Usersinfo
            {
                id=i.Id,Codemeli=i.Codemeli,Email=i.Email,UserName=i.UserName
            }).ToList();
            return View(model);
        }
       
       
        public async  Task<IActionResult> DeleteUser(string id)
        {
            if (string.IsNullOrEmpty(id)) return NotFound();
            var user = await userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            await userManager.DeleteAsync(user);
            return RedirectToAction("index");
        }
        
    }
}
