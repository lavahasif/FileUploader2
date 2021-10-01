using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace FileUploader2
{
    public class FilesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(get());
        }

        public IActionResult Index2()
        {
            Get2();
            return View(Get2());
        }

        public IEnumerable<string> Get2()
        {
            var provider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
            var contents = provider.GetDirectoryContents("");
            var filePath = Path.Combine("Upload");
            var fileInfoss = provider.GetFileInfo(filePath);
            List<string> fileslist = new List<string>();
            var files = provider.GetDirectoryContents("Upload");

            var fileInfos = files.OrderByDescending(info => info.LastModified).ToList();
            foreach (var fileInfo in fileInfos)
            {
                if (fileInfo.IsDirectory)
                {
                    foreach (var fileInfo1 in Directory.EnumerateFiles(
                        path: "upload/"+fileInfo.Name,
                        "*",
                        SearchOption.AllDirectories))
                    {
                        fileslist.Add(fileInfo1.Replace("upload/",""));
                    }
                }

                fileslist.Add(fileInfo.Name.Replace("upload/",""));
            }


            return fileslist;
            ;
        }

        public IEnumerable<string> get()
        {
            return Directory.EnumerateFiles(
                path: "upload",
                "*",
                SearchOption.AllDirectories);
        }
    }
}