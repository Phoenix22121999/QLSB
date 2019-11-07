using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSB
{
    class Cons
    {
        public static int matrixRow = 7;
        public static int matrixColumn = 6;
        public static int width = 59;
        public static int hight = 39;
        public static int margin = 6;
        //public static String sqlLink = @"Data Source=DESKTOP-0SVJ4PH;Initial Catalog=QLSB;Integrated Security=True";
        public static String[] gio = new string[] { "6h-7h", "7h-8h", "8h-9h", "9h-10h", "10h-11h", "13h-14h", "14h-15h", "15h-16h", "16h-17h", "17h-18h", "18h-19h", "19h-20h", "20h-21h" };
        public static String[] san = new string[] { "Sân 1", "Sân 2", "Sân 3", "Sân 4", "Sân 5", "Sân 6", "Sân 7", "Sân 8", "Sân 9" };
        public static String sqlLink = @"Data Source = localhost; Initial Catalog = QLSB; Integrated Security = True";
    }
}
