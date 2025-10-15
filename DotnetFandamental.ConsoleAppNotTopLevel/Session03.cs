using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFandamental.ConsoleAppNotTopLevel
{
    internal class Session03
    {
        public void Learning()
        {
            //Declare Varibale
            //Type(نوع) nameOfVaribale = intialValue(مقدار دهی اولیه);
            string ageStr = "25";
            int age = int.Parse(ageStr);
            Convert.ToInt32(ageStr);
            long ageLong = long.Parse(ageStr);
            decimal.Parse(ageStr);
            double.Parse(ageStr);

            ageStr = age.ToString();

            short shortNumber = 5;
            int intNumber = 15;
            intNumber = shortNumber;

            shortNumber = (short)intNumber;
        }
    }
}
