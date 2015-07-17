namespace ClassChef
{
    using System;
    public class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsCut = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public override string ToString()
        {

            string name = this.GetType().Name;
            string peeled = this.IsPeeled ? "peeled" : "not peeled";
            string cut = this.IsCut ? "cut" : "not cut";

            return string.Format("{0} - {1}/{2}", name, peeled, cut);
        }
    }
}
