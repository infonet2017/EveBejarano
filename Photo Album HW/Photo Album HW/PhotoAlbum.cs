using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Album_HW
{
    class PhotoAlbum
    {
        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return this.NumberOfPages;
        }

        public void SetNumberOfPages(int n)
        {
            this.NumberOfPages = n;
        }

        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int numberPages)
        {
            NumberOfPages = numberPages;
        }


    }
}
