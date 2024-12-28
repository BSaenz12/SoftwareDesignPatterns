using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.DesignPatterns
{
    public interface ICar
    {
        void Assemble();
    }

    public class BasicCar : ICar
    {
        public void Assemble() => Console.WriteLine("Basic Car.");
    }

    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        protected CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual void Assemble() => _car.Assemble();
    }

    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding features of Sports Car.");
        }
    }

    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding features of Luxury Car.");
        }
    }

}
