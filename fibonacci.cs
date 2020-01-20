// The most efficent solution to the question is to only iterate over the even elements of the Fibonacci sequence
// If we take a closer look at Fibonacci sequence, we can notice that every third number in sequence is even
// Recurrence for Even Fibonacci sequence is:
//      EFn = 4EFn-1 + EFn-2
// with seed values
//      EF0 = 0 and EF1 = 2

using System;

class Fibonacci{

    // Returns sum of even Fibonacci  
    // numbers which are less than or 
    // equal to given limit. 

    static int evenFibSum(int limit) 
    { 
        if (limit < 2) 
            return 0; 
      
        // Initialize first two even 
        // prime numbers and their sum 
        long ef1 = 0, ef2 = 2; 
        long sum = ef1 + ef2; 
      
        // calculating sum of even  
        // Fibonacci value 
        while (ef2 <= limit) 
        { 
              
            // get next even value of  
            // Fibonacci sequence 
            long ef3 = 4 * ef2 + ef1; 
      
            // If we go beyond limit, 
            // we break loop 
            if (ef3 > limit) 
                break; 
      
            // Move to next even number 
            // and update sum 
            ef1 = ef2; 
            ef2 = ef3; 
            sum += ef2; 
        } 
      
        return(int) sum; 
    } 

    public static void Main ()  
    { 
        int limit = 5000000; 
        Console.Write(evenFibSum(limit)); 
          
    } 
} 