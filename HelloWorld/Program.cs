namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
         // Declare and initialize the first two double variables
            double luku1 = 10.5;
            double luku2 = 5.5;

            // Declare the other four variables (initially uninitialized)
            double tulo, erotus, summa, osamaara;

            // Perform the calculations
            summa = luku1 + luku2;
            erotus = luku1 - luku2;
            tulo = luku1 * luku2;
            osamaara = luku1 / luku2;

            // Output the results using WriteLine
            Console.WriteLine("Peruslaskujen tulokset:");
            Console.WriteLine("Tulo: " + tulo);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("Osamäärä: " + osamaara);

        }
    }
}
