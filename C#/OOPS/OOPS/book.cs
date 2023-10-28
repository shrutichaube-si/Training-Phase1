using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class book
    {
        string title { get; set; }
        string author { get; set; }
        string genre { get; set; }
        int quan { get; set; }

        public book(string title,string author,string genre,int quan)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.quan = quan;

        }


    }
}
