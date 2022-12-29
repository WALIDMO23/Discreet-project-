using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PerfectNumber
{
	public class Program
	{
		public static void Main(string[] args)
       { 
    
    int s,e,w=0 ;
    
       Console.WriteLine("Enter The Start : ");
       s = int.Parse(Console.ReadLine());
       
       Console.WriteLine("Enter The End : ");
       e = int.Parse(Console.ReadLine());
        
        for (int n = s ; n <= e; n++)
        { 
        	if (n<=0) 
        	continue;
        	
        	w = 0 ;
        	
        	for (int x = 1 ; x<n ; x++)
        	{
        	 if  (n%x==0) 
              
        	  {
        	  	    w += x; 
           	  }
        	}
           	  if (w==n)
        	 	{
        	 		Console.WriteLine("\t"+n);
        	 	}
        	}
        	 	
        	
        	
        
        Console.ReadKey();
     
          
  	 }	
  }
}
