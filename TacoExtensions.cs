using csharp9demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9demo
{

    /// <summary>
    /// 
    /// </summary>
    public static class TacoExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IEnumerator<Ingredient> GetEnumerator(
            this Taco t)
        {
            
            if(!(t.Seasoning is null)) yield return t.Seasoning;
            if (!(t.Condiment is null)) yield return t.Condiment;
            if (!(t.Mixin is null)) yield return t.Mixin;
            if (!(t.BaseLayer is null)) yield return t.BaseLayer;
            if (!(t.Shell is null)) yield return t.Shell;

        }

    }

}
