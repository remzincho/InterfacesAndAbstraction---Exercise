﻿using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Rebel : IName, IBuyer, IAge
    {
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.group = group;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}