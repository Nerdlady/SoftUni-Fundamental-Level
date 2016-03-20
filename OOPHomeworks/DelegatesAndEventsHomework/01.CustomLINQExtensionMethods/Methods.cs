using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods
{
    public static class Methods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var param in collection)
            {

                if (predicate(param))
                {
                   continue;
                    
                }
                else
                { 
                    result.Add(param);
                }
            }
            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate)
            where TSelector : IComparable
        {
            
            TSelector max = predicate(collection.First());
            foreach (var param in collection)
            {
                
                if (max.CompareTo(predicate(param)) < 0)
                {
                    max = predicate(param);
                } 
            }
            return max;
        }
    }
}
