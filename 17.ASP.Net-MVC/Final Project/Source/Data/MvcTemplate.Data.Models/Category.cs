namespace MvcTemplate.Data.Models
{
    using System.Collections.Generic;
    using MvcTemplate.Data.Common.Models;

    public class Category : BaseModel<int>
    {
        private ICollection<Place> places;

        public Category()
        {
            this.places = new HashSet<Place>();
        }

        public string Name { get; set; }

        public virtual ICollection<Place> Place
        {
            get { return this.places; }
            set { this.places = value; }
        }
    }
}