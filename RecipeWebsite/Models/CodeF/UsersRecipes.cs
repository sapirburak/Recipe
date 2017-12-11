namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsersRecipes
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
                public virtual List<Recipe> Recipes { get; set; }
                public virtual List<User> Users { get; set; }
    }
}
