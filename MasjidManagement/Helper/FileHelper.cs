using System;
using System.IO;
namespace MasjidManagement.Helper

{
    public static class FileHelper
    {
        public static bool SaveFile(IFormFile files, string UploadedFile)
        {
            if (files == null || files.Length == 0)
            {
                return false;
            }

            if (!Directory.Exists(UploadedFile))
            {
                Directory.CreateDirectory(UploadedFile);
            }

            var fileName = Path.GetFileName(files.FileName);
            var filePath = Path.Combine(UploadedFile, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                files.CopyTo(stream);
            }
            return true;
        }


		public static bool DeleteFile(string filePath)
		{
			if (File.Exists(filePath))
			{
				File.Delete(filePath);
				return true;
			}
			return false;
		}


		public static FileStream? GetFileStream(string filePath)
		{
			if (File.Exists(filePath))
			{
				return new FileStream(filePath, FileMode.Open, FileAccess.Read);
			}
			return null;
		}



		public static string GetContentType(string fileName)
		{
			var fileExtension = Path.GetExtension(fileName.ToLowerInvariant());

			switch (fileExtension)
			{
				case ".pdf":
					return "application/pdf";

				case ".jpg":
				case ".jpeg":
					return "image/jpeg";

				case ".png":
					return "image/png";

				default:
					return "application/octet-stream";
			}
                                                                        
		}


	}
}

