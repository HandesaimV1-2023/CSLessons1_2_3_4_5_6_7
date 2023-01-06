using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_group1
{
    public partial class Malben
    {
        public int Orech { get; set; }
        public int Rochav { get; set; }


        public override string ToString()
        {
            return  String.Format("orech {0}, rochav {1} ",Orech,Rochav );
        }
    }
}
