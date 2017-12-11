namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductsRecipes
    {
        public int ID { get; set; }

        public int RecipeID { get; set; }

        public int ProductID { get; set; }
        public virtual List<Recipe> Recipes { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
