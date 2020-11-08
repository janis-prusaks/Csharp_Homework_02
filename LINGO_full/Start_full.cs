using System;
using System.Collections.Generic;
using System.Text;

namespace LINGO
{
    class Start_full
    {
              

        public static string atminamaisVards()
        {
            //šeit ieraksta atminamo vārdu.
            return "ziemassvētki";
        }

        
        public static void apraksts()
        {
            string v = atminamaisVards();
            Console.WriteLine($"Uzmini vārdu no {v.Length} burtiem,\n" +
                               "Ja būsi uzminējis kādu no burtiem, tas parādīsies uz ekrāna.\n" +
                               "Ja apnīk minēt, ieraksti APNIKA.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();

        }   
        
    }
}
