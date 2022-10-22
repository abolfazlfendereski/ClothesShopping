using BissnessEntity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MansStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private UserManager<UserApp> userManager;
        private SignInManager<UserApp> signInManager;
        public AccountController(UserManager<UserApp> userManager, SignInManager<UserApp> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Register()
        {
            await createUsersRole();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Models.RegisterModel RM)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(RM.username);
                if (user != null)
                {
                    ModelState.AddModelError("", "این نام کاربری موجود میباشد");
                    return View(RM);
                }
                else
                {
                    var newuser = new UserApp
                    {
                        UserName = RM.username,
                        Codemeli = RM.codemeli,
                       
                        Email = RM.Email,
                        EmailConfirmed = true
                    };
                    var addresult = await userManager.CreateAsync(newuser, RM.Password);
                    if (addresult.Succeeded)
                    {
                        var result1 = await userManager.AddToRoleAsync(newuser, "Users");
                        return RedirectToAction("index", "Home");
                    }
                    foreach (var item in addresult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }              
               
            }
            return View("Register");
        }
        public async Task<IActionResult> Login(string returnUrl=null)
        {
            await createAdminRole();
            ViewData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Models.LoginModel model,string returnUlr =null)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.username);
                if (user == null)
                {
                    ModelState.AddModelError("", "کاربری با این نام کاربری پیدا نشد");
                    return View(model);
                }
                ViewData["returnUrl"] = returnUlr;
                var signinResult = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);
                if (signinResult.IsLockedOut)
                {
                    ViewBag.Error = "اکانت شما به دلیل 5بار ورود ناموفق به مدت 5 دقیقه قفل شده است";
                    return View("Login", model);
                }
                if (!signinResult.Succeeded)
                {

                    ModelState.AddModelError("", "نام کاربری یا پسورد اشتباه است");
                    return View(model);

                }
                else
                {
                    if (!string.IsNullOrEmpty(returnUlr)&& Url.IsLocalUrl(returnUlr))
                    {
                        return Redirect(returnUlr);
                    }
                    var Claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier,user.Id),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(ClaimTypes.Role,"User")                    
                    };
                    return RedirectToAction("index", "Home");
                }
               
            }
          
            


            return View();
        }
        private async Task createAdminRole()
        {
            bool x = await _roleManager.RoleExistsAsync("Admin");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                await _roleManager.CreateAsync(role);
                var user = new UserApp()
                {
                    
                    UserName = "abolfazl",
                    Codemeli = "9876543210",
                    Email="fendereskiabolfazl@gmail.com",
                    EmailConfirmed=true
                };


                string userPWD = "1234";
                var chkUser = await userManager.CreateAsync(user, userPWD);
                if (chkUser.Succeeded)
                {
                    var result1 = await userManager.AddToRoleAsync(user, "Admin");
                }
            }

        }
        private async Task createUsersRole()
        {
            bool x = await _roleManager.RoleExistsAsync("Users");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Users";
                await _roleManager.CreateAsync(role);
            }

        }
       
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ISEmailInUse(string email)
        {
            var user =await userManager.FindByEmailAsync(email);
            if (user == null) return Json(true);
            return Json("ایمیل وارد شده قبلا استفاده شده");
        }
        public async Task<IActionResult> ISUserNameInUse(string email)
        {
            var user = await userManager.FindByNameAsync(email);
            if (user == null) return Json(true);
            return Json("نام کاربری وارد شده قبلا استفاده شده");
        }
        public async Task<IActionResult> ISCodemeliInUse(string email)
        {
            var user = await userManager.FindByNameAsync(email);
            if (user == null) return Json(true);
            return Json("کدملی وارد شده قبلا استفاده شده");
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(chngpass chngpass)
        {
            var user = await userManager.FindByIdAsync(ClailmUtility.GetUserId(User));
            await userManager.ChangePasswordAsync(user,chngpass.ConfirmPass,chngpass.NewPass);
            return RedirectToAction("ChangePassword","Settings");

        }
    }
}
