using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterGame
{
    class ProgramMasterGame
    {
        static void Main()
        {
            Console.WriteLine("Haluatko pelata peliä 1 vai 2?");
            string vastaus = Console.ReadLine();

            try
            {
                if (int.Parse(vastaus) == 1)
                {
                    Quizz.ProgramQuizzT.Main();
                }

                if (int.Parse(vastaus) == 2)
                {
                    Kysymykset.ProgramQuizzJ.Main();
                }

                else
                {
                    Main();
                }
            }
            catch
            {
                Main();
            }
        }
    }
}
