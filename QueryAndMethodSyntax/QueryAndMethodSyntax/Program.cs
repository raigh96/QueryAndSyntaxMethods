using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAndMethodSyntax
{

    class Program
    {
        static void Main(string[] args)
        {
            List <int> AList = new List<int>()
              {
                   1, 2, 3
              };

            List <int> BList = new List<int>()
              {
                    2, 3
              };
        }

        private static IEnumerable <int> SyntaxMethod (List<int> AList, List<int> BList)
        {
                return AList.Where(x => !BList.Contains(x));
        }

        private static IEnumerable <int> QueryMethod (List<int> AList, List<int> BList)
        {
            var query = from x in AList
                        join y in BList on x equals y into lists
                        where !BList.Contains(x)
                        select x;
            return query;
        }

    }
}
 