using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChef
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }
        private Carrot GetCarrot()
        {
            return new Carrot();
        }
        private Potato GetPotato()
        {
            return new Potato();
        }
        private void Cut(Vegetable vegetable)
        {
            vegetable.Cut();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel();
        }

        public Bowl Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();;
            
            Peel(potato);
            Peel(carrot);            
            
            Cut(potato);
            Cut(carrot);
            
            bowl.Add(carrot);
            bowl.Add(potato);

            return bowl;
        }
        
    }
}
