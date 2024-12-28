using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.DesignPatterns
{
    public interface IProduct
    {
        void Use();
    }

    public class ProductA : IProduct
    {
        public void Use() => Console.WriteLine("Using Product A");
    }

    public class ProductB : IProduct
    {
        public void Use() => Console.WriteLine("Using Product B");
    }

    public abstract class ProductFactory
    {
        public abstract IProduct CreateProduct();
    }

    public class ProductAFactory : ProductFactory
    {
        public override IProduct CreateProduct() => new ProductA();
    }

    public class ProductBFactory : ProductFactory
    {
        public override IProduct CreateProduct() => new ProductB();
    }

}
