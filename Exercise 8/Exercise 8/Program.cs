namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //print all even #s from 0 to the maximum #
           Console.WriteLine("Enter a Maximum  number");
           int maxnumber;
           int printednumber = 0;
          
           maxnumber= int.Parse(Console.ReadLine());
            
            //print even #s from 1-Max(15)
            for (printednumber = 0; printednumber <=maxnumber; printednumber +=2) 
            { 
                Console.WriteLine(printednumber);
            }
            Console.WriteLine("Enter a Row Width");
            int rowwidth;
            rowwidth = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rowwidth; i++)
            {
                Console.Write("*");
            }
            
            
            
        }
    }
}