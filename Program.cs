namespace Name_Kodam_Daneshjoo_Toolani_tar_ast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ghad = 0;
            int C = 1;
            int Bozorgtarin = -9999;
            string Name = "";
            string NameFinal = "";
            for ( int i = 0; i <=9; i++)
            {
                Console.WriteLine("Name Daneshjooye " + C + " ra vared konid");
                Name = Console.ReadLine();
                Console.WriteLine("Ghade Daneshjooye " + C + " ra vared konid");
                Ghad = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Ghad > Bozorgtarin)
                {
                    Bozorgtarin = Ghad;
                    NameFinal = Name;
                }
                C++;
            }
            Console.Clear();
            Console.WriteLine("Boland ghad tarin be name " + NameFinal + " ba ghade " + Bozorgtarin +" mibashad");
        }
    }
}