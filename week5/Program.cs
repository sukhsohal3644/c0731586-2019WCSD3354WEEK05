using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            //a.PlayingWithForLoops();
            //Console.ReadLine();

            var b = new birthday_party();
            b.setupPartyList();
            Console.WriteLine(b.printPartyList());
            Console.WriteLine(b.printPartyList_reverse());
            Console.ReadLine();
        }
    }
    class TestQuestion2
    {
        public int myFavouiteVariable = 0;
        public void PlayingWithForLoops()
        {
            // write a for loop to add 10 numbers
            for (; MyMethod();)
            {
                if (myFavouiteVariable > 10)

                {
                    break;
                }
                Console.WriteLine("i am in the for loop");
            }
        }
        public bool MyMethod()
        {
            myFavouiteVariable++;
            return true;

        }
    }


    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;


        }
        public dog()
        {
        }
        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;


    }
    class birthday_party
    {


        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog Giselle;
        public dog Lulu;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;

        public void setupPartyList()
        {
            peanut = new dog("Peanut", "Bichon");
            fifi = new dog("fifi", "Poodle ");
            clarence = new dog("Clarence", "German Sheppard");
            Giselle = new dog("Giselle", "Border Collie");
            Lulu = new dog("Lulu", "Shitzu");
            roy = new dog("Roy", "Beagle");
            


            peanut.prev_dog = null;
            peanut.next_dog = fifi;
            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;
            clarence.prev_dog = fifi;
            clarence.next_dog = Giselle;
            Giselle.prev_dog = clarence;
            Giselle.next_dog = Lulu;
            Lulu.prev_dog = Giselle;
            Lulu.next_dog = roy;
            roy.prev_dog = Lulu;
            roy.next_dog = null;
            head = peanut;
            tail = roy;

        }
        public string printPartyList()
        {
            string inviteList = "*--";
            temporary = head;
            while (temporary.next_dog != null)
            {

                
                inviteList += temporary.dog_name + " * --- * ";
                temporary = temporary.next_dog;
            }
            inviteList += temporary.dog_name + " *__-";
            return inviteList;

        }

        public string printPartyList_reverse()
        {
            string inviteList = "*--";
            temporary = tail;
            while (temporary.prev_dog != null)
            {


                inviteList += temporary.dog_name + " * --- * ";
                temporary = temporary.prev_dog;
            }
            inviteList += temporary.dog_name + " *__-";
            return inviteList;

        }


    }
}