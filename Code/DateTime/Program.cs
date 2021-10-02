using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            var ptBR = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            DateTime dateTime = new DateTime(2008, 5, 1, 8, 30, 52);
             
            Console.WriteLine(string.Format("{0:yyyy}", dateTime)); // 2008             
            Console.WriteLine(string.Format("{0:MMM dd, yyyy}", dateTime)); // mai. 01, 2008        
            Console.WriteLine(string.Format("{0:ddd MM, yyyy}", dateTime)); // qui. 05, 2008      
            Console.WriteLine(string.Format("{0:dddd MM, yyyy}", dateTime)); // quinta-feira 05, 2008      
            Console.WriteLine(string.Format("{0:MMM ddd dd, yyyy}", dateTime)); // mai. qui. 01, 2008     
            Console.WriteLine(string.Format("{0:MMMM dddd dd, yyyy}", dateTime)); // maio quinta-feira 01, 2008          
            Console.WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}", dateTime)); // 2008-05-01 08:30:52  
            Console.WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}", dateTime)); // 2008-05-01 08:30:52 
            Console.WriteLine(string.Format("{0:MM/dd/yy H:mm:ss zzz}", dateTime)); // 05/01/08 8:30:52 -03:00
            Console.WriteLine(dateTime.ToString("dd MMMM 'de' yyyy", ptBR)); // 01 maio de 2008 
            Console.WriteLine(dateTime.ToString("dd/MM/yyyy", ptBR)); // 01/05/2008
        }
    }
}