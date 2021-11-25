using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploader2.Controllers
{
    [Route("api/[controller]")]
    public class ApiUploadController : Controller
    {
        
        // [DisableRequestSizeLimit]
        [HttpPost("fileupload")]
        [RequestFormLimits(MultipartBodyLengthLimit = 30009715200)]
        [RequestSizeLimit(30009715200)]
        public async Task<ActionResult> Files(List<IFormFile> files)
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
        // public HttpResponseMessage  Files()
        // {
        //     HttpResponseMessage result = null;  
        //     var httpRequest = HttpContext.Current.Request;  
        //     if (httpRequest.Files.Count > 0)  
        //     {  
        //         var docfiles = new List<string>();  
        //         foreach (string file in httpRequest.Files)  
        //         {  
        //             var postedFile = httpRequest.Files[file];  
        //             var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);  
        //             postedFile.SaveAs(filePath);  
        //             docfiles.Add(filePath);  
        //         }  
        //         result = Request.CreateResponse(HttpStatusCode.Created, docfiles);  
        //     }  
        //     else  
        //     {  
        //         result = Request.CreateResponse(HttpStatusCode.BadRequest);  
        //     }  
        //     return result;  
        //     
        // }

        [HttpPost("text")]
        public IActionResult Text([FromBody] string content)
        {
            WriteToFile(content);
            return StatusCode(200);
        }

        public static async Task WriteToFile(string readAllText)
        {
            var logPath = @"log2.txt";
            // var readAllText = "";
            if (System.IO.File.Exists(logPath))
            {
                await create(logPath, readAllText);
            }
            else
            {
                System.IO.File.Create(logPath);
                await create(logPath, readAllText);
            }
            // try
            // {
            //     readAllText = System.IO.File.ReadAllText(logPath);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }
            //
            // readAllText = content + "\n" + readAllText;
        }

        private static async Task create(string logPath, string readAllText)
        {
            var allText = System.IO.File.ReadAllText(logPath);
            using (var writer = System.IO.File.CreateText(logPath))
            {
                await writer.WriteLineAsync(readAllText + "\n" + allText);
            }
        }
    }
}