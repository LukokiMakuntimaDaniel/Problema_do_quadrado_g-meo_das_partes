using System;

namespace Problema_do_quadrado_gêmeo_das_partes
{
    class Program
    {
        public static bool dividirESomar(int n)
        {
            string nString = n.ToString();
            for(int cont=0; cont < nString.Length; cont++)
            {
                if (cont + 1 < nString.Length)
                {
                    int primeiraParte = int.Parse(nString.Substring(0, cont + 1));
                    int outraParte = int.Parse(nString.Substring(cont + 1));
                    if( (primeiraParte+outraParte)*(primeiraParte+outraParte)==n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            if(dividirESomar( Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
