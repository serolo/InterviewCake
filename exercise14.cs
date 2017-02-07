/*
Exercise 14

You've built an in-flight entertainment system with on-demand movie streaming.
Users on longer flights like to start a second movie right when their first one ends, but they complain that the plane usually lands before they can see the ending. So you're building a feature for choosing two movies whose total runtimes will equal the exact flight length.

Write a function that takes an integer flightLength (in minutes) and a list of integers movieLengths (in minutes) and returns a boolean indicating whether there are two numbers in movieLengths whose sum equals flightLength.

When building your function:

Assume your users will watch exactly two movies
Don't make your users watch the same movie twice
Optimize for runtime over memory

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
            int[] moviesLenght = new int[] {1,2,3,4,5,6,7,8,9,10};
            int flightLength = 12;

            Console.WriteLine( CanSeeTwoMovies1(flightLength, moviesLenght) );
        }

        /*
            Time Complexity: O(n log n)
            Space Complexity: O(n)
        */
        public static bool CanSeeTwoMovies1( int flightLength, int[] moviesLenght ) {
        	moviesLenght = moviesLenght.Order();
        	int lowerIndex = 0, upperIndex = moviesLenght.Length-1;
        	while( lowerIndex < upperIndex ) {
        		int lowerValue = moviesLenght[lowerIndex],
        			upperValue = moviesLenght[upperIndex];
        		if( flightLength == lowerValue + upperValue ) {
        			return true;
        		}
        		else if( flightLength < lowerValue + upperValue ) {
        			upperIndex--;
        		}
        		else {
        			lowerIndex++;
        		}
        	}
        	return false;
        }
    }
}