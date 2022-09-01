﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPatternDecorator.ConcreteDecorator
{
    internal class Pepper : BaseDecorator.ElementDecorator
    {
        public Pepper(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Pepper";
        public override double Price => 1.00 + elementToDecorate.Price;
    }
}
