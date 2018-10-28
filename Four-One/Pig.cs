namespace Four_One
{
    internal class Pig
    {
        string talk;

        public Pig(string talk)
        {
            this.talk = talk;
        }

        public string Speaks()
        {
            return talk;
        }
    }
}