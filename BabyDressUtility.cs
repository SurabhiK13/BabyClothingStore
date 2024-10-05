using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class BabyDressUtility
    {
        public  void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);
            
        }
        public bool RemoveDressFromCart(string brand)
        {
            BabyDress dressToRemove = Program.DressesCart.Find(dress => dress.Brand == brand);
            if (dressToRemove != null)
            {
                Program.DressesCart.Remove(dressToRemove);
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
