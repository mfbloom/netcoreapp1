using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebAPIApplication.Models
{
    public class Calculate 
    {
        public static int Outcome(int a, int b)
        {
            // We have an intentional bug here
            // + should be *
            return a + b; 
        }
    }
}