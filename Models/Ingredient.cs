using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9demo.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Ingredient
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public string Recipe { get; set; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public string Slug { get; set; } = null!;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool NameHasPunctuation()
        {

            foreach (var c in Name)
            {

                // any character that isn't a letter or space is punctuation
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == ' ')))
                    return true;

                //if (c is not ((>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or (c == ' ')))
                //    return true;

                /* C# 9.0 - Pattern matching enhancements
                 * Notes:
                 *  - ?
                 */

            }

            return false;

        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="newName"></param>
        ///// <returns></returns>
        //public virtual Ingredient SwapName(string newName) =>
        //    new Ingredient
        //    {
        //        Url = string.Empty, // the new ingredient is no longer from the db
        //        Name = newName,
        //        Recipe = Recipe,
        //        Slug = string.Empty // the new ingredient is no longer from the db
        //    };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newName"></param>
        /// <returns></returns>
        public virtual Ingredient SwapName(string newName) =>
            new ()
            {
                Url = string.Empty, // the new ingredient is no longer from the db
                Name = newName,
                Recipe = Recipe,
                Slug = string.Empty // the new ingredient is no longer from the db
            };

        /* C# 9.0 - Target-type new expressions
         * Notes:
         *  - ?
         */

    }

}
