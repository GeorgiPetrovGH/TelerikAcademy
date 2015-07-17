namespace ClassChef
{
    using System;
    using System.Collections.Generic;
    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }
        public ICollection<Vegetable> Ingredients { get; set; }
        public void Add(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }

        public override string ToString()
        {            
            return string.Join("\n", this.Ingredients);
        }
    }
}
