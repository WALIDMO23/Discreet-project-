using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PRIME_NUMBER
{
	public class Program
	{
		public static void Main(string[] args)
   {
    double x,y,e=0  ;
   
    Console.WriteLine("Enter The START : ");
    x = double.Parse(Console.ReadLine());
   
    Console.WriteLine("Enter The END : ");
    y = double.Parse(Console.ReadLine());

     for(double z=x ;z <= y ; z++ )
	        { 
	        	for (int w = 1 ; w < y ;w++) 
	        	{
	        		if (z%w==0)
	        {
	        	e++ ;
	        }
	        	}
	        if (e==2) 
	       {
	        Console.WriteLine(z);
	        }	
	        	
	       e=0 ; 	
	        }
	      
	   
     Console.ReadKey();		
		}
	}	
	