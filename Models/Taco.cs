using System;
using System.Collections.Generic;
using System.Text;

namespace csharp9demo.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Taco : Ingredient
    {

        /// <summary>
        /// 
        /// </summary>
        public Ingredient? Seasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Ingredient? Condiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Ingredient? Mixin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Ingredient? BaseLayer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Ingredient? Shell { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            var sb = new StringBuilder($"{Name}: {BaseLayer?.Name}");

            if (Mixin != null || Condiment != null) sb.Append(" covered in ");
            if (Mixin != null) sb.Append(Mixin.Name);
            if (Mixin != null && Condiment != null) sb.Append(" and ");
            if (Condiment != null) sb.Append(Condiment.Name);
            if (Seasoning != null) sb.Append($", topped with {Seasoning.Name}");
            if (Shell != null) sb.Append($" in a {Shell.Name} shell");
            return sb.ToString();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Taco GetEmptyTaco() =>
            new Taco();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsFull() =>
            !(Seasoning is null)
                && !(Condiment is null)
                && !(Mixin is null)
                && !(BaseLayer is null)
                && !(Shell is null);



        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="newName"></param>
        ///// <returns></returns>
        //public override Ingredient SwapName(string newName)
        //{

        //    //
        //    var t = new Taco
        //    {
        //        Url = string.Empty,
        //        Name = newName,
        //        Recipe = Recipe,
        //        Slug = string.Empty,
        //        Seasoning = Seasoning,
        //        Condiment = Condiment, 
        //        Mixin = Mixin,
        //        BaseLayer = BaseLayer,
        //        Shell = Shell
        //    };

        //    //
        //    return t;

        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="newName"></param>
        /// <returns></returns>
        public override Taco SwapName(string newName)
        {

            //
            var t = new Taco
            {
                Url = string.Empty,
                Name = newName,
                Recipe = Recipe,
                Slug = string.Empty,
                Seasoning = Seasoning,
                Condiment = Condiment,
                Mixin = Mixin,
                BaseLayer = BaseLayer,
                Shell = Shell
            };

            //
            return t;

        }

        /* C# 9.0 - Covarian return type
         * Notes:
         *  - Covariant return types allow for an override method to declare a more derived return 
         *  type than the method it overrides. It is a common pattern in code that different method 
         *  names have to be invented to work around the language constraint that overrides must 
         *  return the same type as the overriden method. This would be useful in the factory 
         *  pattern.
         */

    }

}
