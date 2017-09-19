using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Album_HW
{
    class BigPhotoAlbum
    {
        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return this.NumberOfPages;
        }

        public BigPhotoAlbum()
        {
            this.NumberOfPages = 64;
        }
    }
}
