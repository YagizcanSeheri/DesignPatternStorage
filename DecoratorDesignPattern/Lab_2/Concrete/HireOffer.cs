using DecoratorDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Lab_2.Concrete
{
    public class HireOffer : CarDecortorBase
    {
        private readonly CarBase _carBase;

        public HireOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public int DiscountPercentage { get; set; }

        public override string Make { get; set; }
        public override string Model { get; set; }

        public override decimal HirePrice
        {
            get { return _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage / 100; }
            set { }
        }
    }
}
