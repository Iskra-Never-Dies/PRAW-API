using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAW
{
    internal static class Extension
    {
        /// <summary>
        /// MDAFR: ms devs are fucking retards
        /// </summary>
        /// <param name="val"></param>
        /// <returns>ToString of <param name="val"></returns>
        //public static string? MDAFR(this object val) =>
        //    val?.ToString();

        internal static T Modify<T>(this T Generic, Action<T> _Action)
        {
            _Action(Generic);
            return Generic;
        }
    }
}
