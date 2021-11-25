using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BlazorPdflist.Data
{
    public class FileService
    {
        public List<IFileInfo> GetFileInfos()
        {

            var provider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
            var contents = provider.GetDirectoryContents("");
            var filePath = Path.Combine("Upload");
      
            
            var fileInfoss = provider.GetFileInfo(@"pdf");
            List<string> fileslist = new List<string>();
            var files = provider.GetDirectoryContents(@"pdf");

            var fileInfos = files.OrderByDescending(info => info.LastModified).ToList();
            return fileInfos;
        }


        public IEnumerable<string> Get2()
        {
            var provider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
            var contents = provider.GetDirectoryContents("");
            var filePath = Path.Combine("Upload");
            var fileInfoss = provider.GetFileInfo(@"D:\s\pdf");
            List<string> fileslist = new List<string>();
            var files = provider.GetDirectoryContents("Upload");

            var fileInfos = files.OrderByDescending(info => info.LastModified).ToList();
            foreach (var fileInfo in fileInfos)
            {
                if (fileInfo.IsDirectory)
                {
                    foreach (var fileInfo1 in Directory.EnumerateFiles(
                        path: "upload/" + fileInfo.Name,
                        "*",
                        SearchOption.AllDirectories))
                    {
                        fileslist.Add(fileInfo1.Replace("upload/", ""));
                    }
                }

                fileslist.Add(fileInfo.Name.Replace("upload/", ""));
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
