using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favoritFood;
        public string Name
        {
            get;
            protected set;
        }
        public string FavoritFood
        {
            get;
            protected set;
        }
        protected Animal(string name,string favoritFood)
        {
            this.name = name;
            this.favoritFood = favoritFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my favoritfood is {this.favoritFood}";
        }
    }
}
