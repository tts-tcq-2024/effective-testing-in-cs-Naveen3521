using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Debug.Assert(Size(37) == "S");// test for small size
            Debug.Assert(Size(40) == "M");// test for medium size
            Debug.Asser(Size(38)=="M");// Edge Case Added (Should return M but it is not handled)
            Debug.Assert(Size(43) == "L");// valid
            Debug.Assert(Size(-1) == "Invalid negative value");//test to check when invalid size is given
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
