﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quckBehavior = new Quack();
        }
        public override string display()
        {
            return "Кряква " + this.GetType();
        }
        public string quack()
        {
            return "Кря-кря " + this.GetType();
        }
        public string fly()
        {
            return "*Порхаю как бабочка* " + this.GetType();
        }
    }
}
