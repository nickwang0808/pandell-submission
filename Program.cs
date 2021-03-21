using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Because we know that we need a range of integer within a certain parameter, 
        and we need all of the integers within that range.

        So I'm just going to create an Enumerable in the range of 1 - 10,000,

        The next step is to randomly shuffle it, 
        luckily C# has a cool little trick where we can use Linq.Orderby(a random value)
        to shuffle the IEnumerable, and the best way to create a random value is just utilize
        the Guid class.

        Finally, we make it to a list so we can run the join operation and print the result out 
        in the console

        The operation to create the Enumerable is linear to the given range, so the 
        time and space complexity is O(n). 

        Base on information on the internet, see https://stackoverflow.com/questions/2792074/what-sorting-algorithm-is-used-by-linq-orderby/2792105#2792105
        the OrderBy operation uses stable quick sort under the hood, which has the 
        the time complexity of O(N*logN).

        The time complexity of Guid generation is constant regardless of the input size, so we can just 
        ignore it.
         */

        #region main code

        List<int> randList = Enumerable.Range(1, 10000)
            .OrderBy(e => Guid.NewGuid())
            .ToList();

        #endregion

        Console.WriteLine(string.Join("\n ", randList));
    }
}
