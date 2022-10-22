using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MansStore.Models;
using BissenessLagicLayer;
using BissnessEntity;
namespace MansStore.ViewComponent.User
{
    public class GetMenuComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        BlProductUs bll = new BlProductUs();
        public IViewComponentResult Invoke()
        {
            var menuitem = bll.Menu();
            return View(viewName: "GetMenuComponent", menuitem);
        }
    }
}
