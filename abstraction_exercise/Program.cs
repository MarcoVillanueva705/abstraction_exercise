using System;

namespace abstraction_exercise
{
    interface IAnimal
    {
        void animalsound();
    }
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

        class Wild: Monkey
        {
            public override void MonkeySound()
            {
                //base.MonkeySound();
                Console.WriteLine("Ooh aah eee!");
            }
        }

    class Safari : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Cheeezzaaayyy!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Monkey coolMonkey = new Monkey();
            Wild thisWild = new Wild();
            coolMonkey.MonkeySound();
            thisWild.MonkeySound();
            coolMonkey.Name = "Chimpo";
            coolMonkey.Fur = true;
            Console.WriteLine(coolMonkey.Name);
            Console.WriteLine(coolMonkey.Fur);
            
        }
    }
}
