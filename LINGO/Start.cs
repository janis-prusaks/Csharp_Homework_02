using System;
using System.Collections.Generic;
using System.Text;

namespace LINGO
{
    class Start
    {
              

        public static string atminamaisVards()
        {
            //šeit ieraksta atminamo vārdu, ja būs vairāk vai mazāk par 5 burtiem, pamatprogr nedarbosies.
            return "ziema";
        }

        
        public static void apraksts()
        {
            Console.WriteLine("Uzmini vārdu no 5 burtiem,\n" +
                               "(vārdā nav izmntoti burti ar garumzīmēm vai mīkstinājuma zīmēm).\n" +
                               "Ja būsi uzminējis kādu no burtiem, tas parādīsies uz ekrāna.\n" +
                               "Ja apnīk minēt, ieraksti APNIKA.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();

        }   
        
    }
}
