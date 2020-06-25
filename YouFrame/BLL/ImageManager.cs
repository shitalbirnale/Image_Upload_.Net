using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL
{
    public class ImageManager
    {
        public static bool insert(String image)
        {
            //  bool status = false;
            //status = DBManager.insert(student);
            return DBManager.insert(image);
        }
       
        public static List<Imagedb> GetAllImage()
        {
            List<Imagedb> img = new List<Imagedb>();
            img = DBManager.getAllImage();
            return img;
        }
        


    }
}
