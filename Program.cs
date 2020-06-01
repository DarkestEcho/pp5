using System;
using System.Threading.Tasks;

namespace лб5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int number = 24;
            var a = await GetArrayAsync(number);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        static async Task<int[]> GetArrayAsync(int n)
        {
            int[] resArray = await Task.Run(()=> GetArray(n));

            return resArray;
        }

        static int[] GetArray(int n)
        {
            int[] newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArray[i]=i;
            }
            return newArray;
        }
    }
}
