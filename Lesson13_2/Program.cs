using System.Collections;
using System.Collections.Generic;

namespace Lesson13_2;

#nullable disable


class Program
{
    static IEnumerable<int> ExampleYieldReturn()
    {
        yield return 1;
        yield return 3;
        yield return 5;
        yield return 7;

        if(true)
            yield break;

        yield return 9;
    }


    static void Main()
    {
        //// Yield return
        // foreach (var i in ExampleYieldReturn())
        //     Console.WriteLine(i);



        //// Iterator
        // List<int> list =  Enumerable.Range(5, 10).ToList();
        // IEnumerator<int> iterator = list.GetEnumerator();
        // 
        // 
        // while (iterator.MoveNext())
        //     Console.WriteLine(iterator.Current);
        // iterator.Reset();
        // 
        // 
        // while (iterator.MoveNext())
        //     Console.WriteLine(iterator.Current);
        // iterator.Reset();



    }
}