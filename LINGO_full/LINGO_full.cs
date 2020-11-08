using System;

namespace LINGO
{
    class LINGO_full
    {
        static void Main(string[] args)
        {
            //lai spēlētājam nav tieša piekļuve, atminamo vārdu rakstu citā klasē.
            string vards = Start_full.atminamaisVards().ToUpper();
            Start_full.apraksts();           

            //izvada vārda 1 burtu un vārda garumu ar *            
            PirmaisBurts(vards);
            for (int i = 1; i < vards.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

                                 
            string userInput = Console.ReadLine().ToUpper();
            
            while (!userInput.Equals(vards))
            {
                if (userInput.Equals("APNIKA"))
                {
                    Console.WriteLine($"Atminējums ir: {vards} ");
                    return;
                }
                else
                {
                    //pārbauda vārda garumu
                    while (userInput.Length != vards.Length)
                    {
                        Console.WriteLine($"Tas nav vārds ar {vards.Length} burtiem!. Mēģini vēlreiz.");
                        userInput = Console.ReadLine();
                    }
                    userInput = userInput.ToUpper();

                    //salīdzina un izdrukā atminētos burtus                    
                    PirmaisBurts(vards);
                    for (int i = 1; i < userInput.Length; i++)
                    {
                        if (userInput[i].Equals(vards[i]))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(userInput[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Nākošais minējums: ");
                    userInput = Console.ReadLine().ToUpper();

                }
            }

            //spēles beigas
            Console.ForegroundColor = ConsoleColor.Yellow;            
            Console.WriteLine($"{vards}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Apsveicu, esi uzminējis!");
            Console.ResetColor();

        }

        private static void PirmaisBurts(string vards)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(vards[0]);
            Console.ResetColor();
        }
    }
}
