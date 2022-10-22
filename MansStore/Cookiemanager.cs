using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore
{
    public class Cookiemanager
    {
        public string Getvalue(HttpContext context,string Token)
        {
            string CookieValue;
            if (!context.Request.Cookies.TryGetValue(Token,out CookieValue))
            {
                return null;
            }
            return CookieValue;
        }
        public Guid GetBrowserId(HttpContext context)
        {
            string browserId = Getvalue(context, "Browserid");
            if (browserId ==null)
            {
                string Value = Guid.NewGuid().ToString();
                context.Response.Cookies.Append("Browserid", Value,getCookieOption(context));
                browserId = Value;
            }
            Guid guid;
            Guid.TryParse(browserId, out guid);
            return guid;
        }

        private CookieOptions getCookieOption(HttpContext context)
        {
            return new CookieOptions
            {
                HttpOnly = true,
                Path=context.Request.PathBase.HasValue ? context.Request.PathBase.ToString() : "/",
                Secure=context.Request.IsHttps,
                Expires=DateTime.Now.AddDays(100),

            };
        }
    }
}
