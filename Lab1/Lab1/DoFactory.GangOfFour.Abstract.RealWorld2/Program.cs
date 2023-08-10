using System;
using System.Collections.Concurrent;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    class MainApp
    {
        public static void Main()
        {
            ContinentFactory factory1 = new AfricaFactory();
            Client client1 = new Client(factory1);
            client1.Run();

            ContinentFactory factory2 = new AmericaFactory();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }

    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    abstract class Herbivore
    {

    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore a);
    }

    class Wildebeest : Herbivore
    {

    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eat " + h.GetType().Name);
        }
    }

    class Bison : Herbivore
    {

    }

    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eat " + h.GetType().Name);
        }
    }

    class Client
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public Client(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void Run()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}