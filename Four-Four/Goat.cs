﻿namespace Four_Four
{
    internal class Goat
    {
        string name, talk, eat, provide;
        public Goat(string name, string talk, string eat, string provide)
        {
            this.name = name;
            this.talk = talk;
            this.eat = eat;
            this.provide = provide;
        }

        public string Name()
        {
            return name;
        }

        public string Speaks()
        {
            return talk;
        }

        public string Eat()
        {
            return eat;
        }

        public string Provide()
        {
            return provide;
        }
    }
}