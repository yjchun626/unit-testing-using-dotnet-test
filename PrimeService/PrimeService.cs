﻿using System;

namespace Prime.Services
{
    public class PrimeService
    {
        // public bool IsPrime(int candidate)
        // {
        //     if (candidate == 1)
        //     {
        //         return false;
        //     }
        //     throw new NotImplementedException("Not fully implemented.");
        // }

        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}