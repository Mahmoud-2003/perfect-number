﻿using System;
using System.Linq;

namespace perfect
{
	public static class Program
	{
		public static void Main()
		{
          Console.WriteLine("Enter first number :");
          int num1=int.Parse(Console.ReadLine());
          
          Console.WriteLine("=============================================");
          
          Console.WriteLine("Enter second number :");
          int num2=int.Parse(Console.ReadLine());
          
          Console.WriteLine("=============================================");
          
          for(int i=num1 ; i<num2 ;i++)
          {
          	int sum=0;
          	
          	for(int j=1 ; j<=(i/2) ;j++)
          	{
          		if((i%j)==0)
          		{
          			sum+=j;
          		}
          	}
          	if(sum==i)
          	{
          		Console.WriteLine("The number {"+i+"} is perfect");
          	}
          
          }
		}
	}
}