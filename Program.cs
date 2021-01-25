using System;
using System.Threading.Tasks;

/* C# 8.0 and previous versions */
//namespace csharp9demo
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            var httpClient = new System.Net.Http.HttpClient
//            {
//                BaseAddress = new Uri("http://taco-randomizer.herokuapp.com")
//            };
//            // Get a good taco. All tacos are good.
//            Console.WriteLine((await new ApiWrapper(httpClient).GetGoodRandomTaco((t, i) => true)).ToString());
//        }
//    }
//}

/* C# 9.0 - Top-level statement example
 * Notes:
 *  - Without the namespace declaration this code now lives outside of the "csharp9demo" namespace.
 *  As a result, to resolve an error where it cannot find ApiWrapper, we need to fully define the
 *  namespace in code below or by adding a using declaration above with the needed namespace.
 *  - This pattern matches patterns of other lanugagues. 
 */

//
var httpClient = new System.Net.Http.HttpClient
{
    BaseAddress = new Uri("http://taco-randomizer.herokuapp.com")
};

// Get a good taco. All tacos are good.
Console.WriteLine((await new csharp9demo.ApiWrapper(httpClient).GetGoodRandomTaco(static (_, _) => true)).ToString()); // New new line using static anonymous functions
                                                                                                                       //Console.WriteLine((await new csharp9demo.ApiWrapper(httpClient).GetGoodRandomTaco((_, _) => true)).ToString()); // New line using lambda discard parameter
                                                                                                                       //Console.WriteLine((await new csharp9demo.ApiWrapper(httpClient).GetGoodRandomTaco((t, i) => true)).ToString()); // Old line without lamda discard parameter

/* C# 9.0 - Lamda discard parameter
 * Notes:
 *  - Lambda discard parameter can be used for parameters that do not need to be named. The intent
 *  is to make it easy for parameters that are unused/discarded.
 */

/* C# 9.0 - Static anonymous function
 * Notes:
 *  - ?
 */