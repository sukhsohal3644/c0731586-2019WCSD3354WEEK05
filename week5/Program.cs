﻿using System;
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
            a.PlayingWithForLoops();
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
        private dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;


        }
        public dog()
        {
        }
        public string dog_name ;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;


    }
    class birthday_party
    {
        
      
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;
       
        public dog head;
        public dog tail;
        public dog temporary;

        public void setupPartyList()
        {
            peanut = new dog("Peanut", "Bichon");
            fifi = new dog("fifi", "Poodle ");
            clarence = new dog("Clarence", "German Sheppard");
            roy = new dog("Roy", "Beagle");


            peanut.prev_dog = null;
            peanut.next_dog = fifi;
            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;
            clarence.prev_dog = fifi;
            clarence.next_dog = roy;
            roy.prev_dog = clarence;
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
            }

            return inviteList;

        }

    }