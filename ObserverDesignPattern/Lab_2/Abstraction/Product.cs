using ObserverDesignPattern.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Lab_2.Abstraction
{
    public abstract class Product
    {
        public string ProductName { get; set; }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price > value)
                {
                    Notification();
                }
                _price = value;
            }
        }

        public Product(string productName, decimal unitPrice)
        {
            this.ProductName = productName;
            this._price = unitPrice;
        }

        public List<ConcreteMember> FollowList = new List<ConcreteMember>();

        public void Notification()
        {
            foreach (IMember member in FollowList)
            {
                member.Update(this);
            }
        }
    }
}
