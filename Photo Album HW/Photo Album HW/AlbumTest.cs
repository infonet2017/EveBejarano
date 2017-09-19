using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Album_HW
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            var Photo = new PhotoAlbum(); 
            Console.WriteLine("El numero de hojas del primer album es: " + Photo.GetNumberOfPages());

            var Photo2 = new PhotoAlbum(24);
            Console.WriteLine("El numero de hojas del segundo album es: " + Photo2.GetNumberOfPages());

            var Photo3 = new BigPhotoAlbum();
            Console.WriteLine("El numero de hojas del Big album es: " + Photo3.GetNumberOfPages());
            Console.Read();
        }
    }
}
