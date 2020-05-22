using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name,string favoritFood):base(name,favoritFood)
        {

        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + " woof";
        }
    }
}
