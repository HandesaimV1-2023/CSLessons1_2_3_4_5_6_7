using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_group1
{
    public class Egul
    {
        public Action Change;
        int radius;
        public int Radius 
        {
            get { return radius; }
            set { radius = value;
                if (Change != null)
                    Change();
            //כאן תופעל פונקציה להצגת העיגל על המסך מחדש
           // האם אפשר מכאן להפעיל את הפונקציה דרוו
            }
        
        }
        public Nekuda nekuda { get; set; }
        public override string ToString()
        {
            return "tostring";
        }
    }
}
