using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace FileUploader2.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            get();
            return null;
        }

        public IActionResult Get(IFileProvider fileProvider)
        {
            var files = fileProvider.GetDirectoryContents("Upload");

            var latestFile =
                files
                    .OrderByDescending(f => f.LastModified)
                    .FirstOrDefault();

            return Ok(latestFile?.Name);
        }

        public IEnumerable<string> get()
        {
            // foreach (string file in Directory.EnumerateFiles(
            //     path: "upload",
            //     "*",
            //     SearchOption.AllDirectories)
            // )
            // {
            //     try
            //     {
            //         Console.WriteLine(file.ToString());
            //     }
            //     catch (Exception e)
            //     {
            //         Console.WriteLine(e);
            //         
            //     }
            // }

            return Directory.EnumerateFiles(
                path: "upload",
                "*",
                SearchOption.AllDirectories);
        }
    }
}