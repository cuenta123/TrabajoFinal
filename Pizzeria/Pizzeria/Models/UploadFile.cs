using System;
using System.IO;
using System.Text;
using System.Web;

namespace Pizzeria.Models
{
    public static class UploadFile
    {
       static StringBuilder virtualPath;

        public static String Upload(HttpPostedFileBase file, HttpServerUtilityBase Server)
        {     
            String DestDirVPath = "~/Content";
            string destDirPhysPath = Server.MapPath(DestDirVPath);
            string extension = Path.GetExtension(file.FileName);
            String fichero = Path.GetFileNameWithoutExtension(file.FileName);
            fichero = Path.GetFileName(file.FileName);
            StringBuilder FileBuilder = new StringBuilder();
            FileBuilder.Append(destDirPhysPath);
            FileBuilder.Append(Path.DirectorySeparatorChar);
            FileBuilder.Append(Path.GetFileName(file.FileName));
            String rutafinal = FileBuilder.ToString();
            file.SaveAs(rutafinal);
            return GetDestVirtualPath(DestDirVPath,fichero,extension);
        }

        private static String GetDestVirtualPath(String VirtualPath, String fichero,String extension)
        {
            virtualPath = new StringBuilder();
            virtualPath.Append(VirtualPath);
            virtualPath.Append('/');
            virtualPath.Append(fichero);
            return  virtualPath.ToString();
        }

    }
}