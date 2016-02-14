namespace MvcTemplate.Data.Models
{
    using MvcTemplate.Data.Common.Models;
    using System.Collections.Generic;

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