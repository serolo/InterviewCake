/*
Exercise 15

Write a function Fib() that a takes an integer nn and returns the nnth fibonacci ↴ number.
    Fib(0) => 0
    Fib(1) => 1
    Fib(2) => 1
    Fib(3) => 2
    Fib(4) => 3
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 4;

            Console.WriteLine( Fib_1(n) );
            Console.WriteLine( Fib_2(n, new Dictionary<int, int>() ) );
            Console.WriteLine( Fib_3(n) );
            Console.WriteLine( Fib_4(n) );
        }

        /*
            Time Complexity: O(n^2)
            Space Complexity: O(1)
        */
        public static int Fib_1( int n ) {
            if( n == 0 ) {
                return 0;
            }
            if( n == 1 || n == 2 ) {
                return 1;
            }

            return Fib_1( n-1 ) + Fib_1( n-2 );
        }

        /*
            Time Complexity: O(n)
            Space Complexity: O(n)
        */
        public static int Fib_2( int n, Dictionary<int,int> saveData ) {
            if( n == 0 ) {
                return 0;
            }
            if( n == 1 || n == 2 ) {
                return 1;
            }
            if( saveData.ContainsKey( n ) ) {
                return saveData[n];
            }

            int result = Fib_2( n-1, saveData ) + Fib_2( n-2, saveData );

            saveData.Add( n, result );
            return result;
        }

        /*
            Time Complexity: O(n)
            Space Complexity: O(n)
        */
        public static int Fib_3( int n ) {
            
            if( n == 0 ) {
                return 0;
            }

            if( n==1 || n==2 ) {
                return 1;
            }

            int[] values = new int[n];
            values[0] = 1;
            values[1] = 1;

            for( int i=2; i<n ; i++ ) {
                values[i] = values[i-1] + values[i-2];
            }

            return values[n-1];
        }

        /*
            Time Complexity: O(n)
            Space Complexity: O(1)
        */
        public static int Fib_4( int n ) {
            
            if( n == 0 ) {
                return 0;
            }

            if( n==1 || n==2 ) {
                return 1;
            }

            int prevValue = 1, prevPrevValue = 1, result = 0;

            for( int i=2; i<n ; i++ ) {
                resul = prevValue+prevPrevValue;
                prevPrevValue = prevValue;
                prevValue = result;
            }

            return result;
        }
    }
}