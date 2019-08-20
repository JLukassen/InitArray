using System;

public class InitArray
{
  
        static void Main(string[] args)
        {
            
            int[] array = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            Console.WriteLine("{0}{1,8}", "Index", "Value");

            for (int counter = 0; counter < array.Length; ++counter)
                Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
        }
    
}
