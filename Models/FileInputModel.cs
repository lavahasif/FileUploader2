using System;

namespace FileUploader2.Models
{
    public class FileInputModel
    {
        public Microsoft.AspNetCore.Http.IFormFile FileToUpload { get; set; }
    }
}
