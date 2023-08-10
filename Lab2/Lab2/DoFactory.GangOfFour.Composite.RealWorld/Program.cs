using System;

namespace DoFactory.GangOfFour.Composite.RealWorld
{
    class MainApp
    {
        static void Main()
        {
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new Primitive("Red Line"));
            root.Add(new Primitive("Blue Circle"));
            root.Add(new Primitive("Green Box"));

            CompositeElement comp = new CompositeElement("Two Circle");
            comp.Add(new Primitive("Black Circle"));
            comp.Add(new Primitive("White Circle"));
            root.Add(comp);

            Primitive pe = new Primitive("Yellow Line");
            root.Add(pe);
            root.Remove(pe);
            root.Display(1);

            Console.ReadKey();
        }
    }

    abstract class DrawingElement
    {
        protected string _name;
        public DrawingElement(string name)
        {
            this._name = name;
        }
        public abstract void Add(DrawingElement c);
        public abstract void Remove(DrawingElement c);
        public abstract void Display(int indent);
    }

    class Primitive : DrawingElement
    {
        public Primitive(string name) : base(name)
        {
        }

        public override void Add(DrawingElement component)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }

        public override void Remove(DrawingElement component)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }
    }

    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();
        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + _name);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
    }
}