﻿using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Builder.Structural
{
    public class MainApp
    {
        public static void Main()
        {
            Diretor diretor = new Diretor();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            diretor.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            diretor.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.ReadKey();
        }
    }

    class Diretor
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}