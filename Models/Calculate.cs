using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebAPIApplication.Models
{
    public class Calculate 
    {
        public static int Multiply(int a, int b)
        {
            return a * b; 
        }
    }
}