using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Maor_Hevron_trendemon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringValidator strValidator = new BracketsStringValidator();
            strValidator.RunStringValidator();
        }
    }
}