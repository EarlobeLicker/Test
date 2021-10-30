//father
class Program
    {
        static void Main(string[] args)
        {
            int min = 1; 
            int max = 2;   
 
            Random random = new Random();
            int number= random.Next(min, max);
 
            Console.WriteLine(number);
 
            Console.ReadLine();
        
        }
    }