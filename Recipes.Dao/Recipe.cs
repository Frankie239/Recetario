using System;
using System.Collections.Generic;

namespace Recipes.Domain
{
    public class  Recipe
    {
        public int Id { get; set; }
        string Title { set; get; }
        public string Author { get; set; }
        public List <string> Igredients { get; set; }
        public string  Steps { get; set; }


    }
}
