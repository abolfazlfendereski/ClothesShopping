using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MansStore
{
    public class UploadFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UploadFile(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;

        }
        public string upload(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\images\\product\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);
            path = path.Split("wwwroot")[1];
            return file.FileName;
        }
        public string uploadSlider(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\images\\Slider\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);
            path = path.Split("wwwroot")[1];
            return file.FileName;
        }
        public string uploadHomeImg(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\images\\Homeimg\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);
            path = path.Split("wwwroot")[1];
            return file.FileName;
        }
        public string uploadHomeCard(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\images\\HomeCard\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);
            path = path.Split("wwwroot")[1];
            return file.FileName;
        }
    }
}
