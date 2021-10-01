using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using FileUploader2.Models;
using System.Diagnostics;
using System.Linq;

namespace FileUploader2.Controllers
{
    public class HomeController : Controller
    {
        //[HttpPost]
        //public async Task<IActionResult> UploadFile(Microsoft.AspNetCore.Http.IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return Content("file not selected");

        //    var path = Path.Combine(
        //                Directory.GetCurrentDirectory(), "wwwroot",
        //               file.FileName);

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    return RedirectToAction("Files");
        //}
        [HttpPost("FileUpload")]
        // [DisableRequestSizeLimit]
        [RequestFormLimits(MultipartBodyLengthLimit = 30009715200)]
        [RequestSizeLimit(30009715200)]
        public async Task<IActionResult> Index2(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath =
                        @"Upload/" +
                        formFile.FileName; //we are using Temp file name just for the example. Add your own file path.
                    filePaths.Add(filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            return Ok(new {count = files.Count, size, filePaths});
        }
        //public async Task<IActionResult> Download(string filename)
        //{
        //    if (filename == null)
        //        return Content("filename not present");

        //    var path = Path.Combine(
        //                   Directory.GetCurrentDirectory(),
        //                   "wwwroot", filename);

        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(path, FileMode.Open))
        //    {
        //        await stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    return File(memory, GetContentType(path), Path.GetFileName(path));
        //}

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            try
            {
                var s = gettext();
                var s2 = gettext2();
                ViewData["url"] = s.Replace("\n\n\n\n", "");
                ViewData["url2"] = s2.Replace("\n\n\n\n", "");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        //private string GetContentType(string path)
        //{
        //    var types = GetMimeTypes();
        //    var ext = Path.GetExtension(path).ToLowerInvariant();
        //    return types[ext];
        //}

        //private Dictionary<string, string> GetMimeTypes()
        //{
        //    return new Dictionary<string, string>
        //    {
        //        {".txt", "text/plain"},
        //        {".pdf", "application/pdf"},
        //        {".doc", "application/vnd.ms-word"},
        //        {".docx", "application/vnd.ms-word"},
        //        {".xls", "application/vnd.ms-excel"},
        //        {".xlsx", "application/vnd.openxmlformats,officedocument.spreadsheetml.sheet"},  
        //        {".png", "image/png"},
        //        {".jpg", "image/jpeg"},
        //        {".jpeg", "image/jpeg"},
        //        {".gif", "image/gif"},
        //        {".csv", "text/csv"}
        //    };
        //}

        public IActionResult Privacy()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Files()
        {
            return RedirectToPage("Files");
        }

        [HttpPost]
        public IActionResult Savetext()
        {
            var dd = ViewData["url"];
            var data = HttpContext.Request.Form["textarea"];
            WriteToFile(data);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Savetext2()
        {
            var dd = ViewData["url2"];
            var data = HttpContext.Request.Form["textarea2"];
            WriteToFile2(data);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Clear()
        {
            var dd = ViewData["url"];
            var data = "";
            // WriteToFile(data);
            return RedirectToAction("Index", "Home");
        }
   [HttpPost]
        public IActionResult Clear2()
        {
            var dd = ViewData["url2"];
            var data = "";
            // WriteToFile(data);
            return RedirectToAction("Index", "Home");
        }

        public static async Task WriteToFile(string content)
        {
            var logPath = @"log.txt";
            using (var writer = System.IO.File.CreateText(logPath))
            {
                await writer.WriteLineAsync(content);
            }
        }

        public static async Task WriteToFile2(string content)
        {
            var logPath = @"log2.txt";
            using (var writer = System.IO.File.CreateText(logPath))
            {
                await writer.WriteLineAsync(content);
            }
        }

        public static string gettext()
        {
            var logPath = @"log.txt";
            if (!System.IO.File.Exists(logPath))
                System.IO.File.Create(logPath);
            using (var writer = new StreamReader(logPath))
            {
                return writer.ReadToEnd().ToString();
            }
        }

        public static string gettext2()
        {
            var logPath = @"log2.txt";
            if (!System.IO.File.Exists(logPath))
                System.IO.File.Create(logPath);


            using (var writer = new StreamReader(logPath))
            {
                return writer.ReadToEnd().ToString();
            }
        }
    }
}