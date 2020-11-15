using System;

namespace abstraction_exercise
{

    class Monkey
    {

        public virtual void MonkeySound()
        {
            Console.WriteLine("Chimp Sounds!");

        }
        private string name;
        private bool fur;

        public string Name
        {
            get; set;
        }

        public bool Fur
        {
            get; set;
        }


    }

    class Wild : Monkey
    {
        public override void MonkeySound()
        {
            //base.MonkeySound();
            Console.WriteLine("Ooh aah eee!");
        }
    }

    //interface IAnimal
    //{
    //    void animalsound();
    //}

    interface IAnimal
    {
        void animalSound(); // interface method
    }

    interface IDonut
    {
        void eatDonut();
    }

    // Implement multiple interfaces
    class Safari : IAnimal, IDonut
    {
        public void animalSound()
        {
            Console.WriteLine("Some text..");
        }

        public void eatDonut()
        {
            Console.WriteLine("MMMmm...Donuuuut");
        }

        //    class Safari : IAnimal
        //{
        //    public void animalSound()
        //    {
        //        Console.WriteLine("Cheeezzaaayyy!");
        //    }
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Monkey coolMonkey = new Monkey();
            Wild thisWild = new Wild();
            Safari badSafari = new Safari();
            badSafari.animalSound();
            coolMonkey.MonkeySound();
            thisWild.MonkeySound();
            badSafari.eatDonut();
            coolMonkey.Name = "Chimpo";
            coolMonkey.Fur = true;
            Console.WriteLine(coolMonkey.Name);
            Console.WriteLine(coolMonkey.Fur);
            
        }
    }
}
