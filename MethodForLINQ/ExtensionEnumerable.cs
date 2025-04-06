using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForLINQ
{
    public static class ExtensionEnumerable
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> vEnumerable,int vX)
        {
            if (vX < 1 || vX > 100)
                throw new ArgumentException("Процент должен быть от 1 до 100");

            return vEnumerable
                .OrderByDescending(x => x)
                .Take((int)Math.Ceiling(vEnumerable.Count() * (vX / 100.0)));
        }
        public static IEnumerable<T> Top<T>(this IEnumerable<T> vEnumerable, int vX, Func<T, int> topX)
        {
            if (vX < 1 || vX > 100)
                throw new ArgumentException("Процент должен быть от 1 до 100");

            return vEnumerable
                .OrderByDescending(topX)
                .Take((int)Math.Ceiling(vEnumerable.Count() * (vX / 100.0)));
        }
    }
}
