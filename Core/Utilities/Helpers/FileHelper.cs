using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;


namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile fromFile)
        {
            string extension = Path.GetExtension(fromFile.FileName);
            string newGuid = CreateGuid() + extension;
            string fullPath = Directory.GetCurrentDirectory() + @"\wwwroot\Images";
            string savePath = @"\Images";

            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
            string imagePath;
            using (FileStream fileStream = File.Create(fullPath + "\\" + newGuid))
            {
                fromFile.CopyTo(fileStream);
                fileStream.Flush();
                imagePath = savePath + "\\" + newGuid;
            }
            return imagePath;
        }
        public static void Delete(string path)//CarImageManger dan gelen değer suan path in içindedir 
        {
            File.Delete(path);//sonra burada File.delete islemi bu yolu alır kontrol eder varsa o dosyayı siler
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }
        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }
        private static string CreateGuid()
        {
            return Guid.NewGuid().ToString("N") + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Year;
        }

    }
}
