namespace Four_One
{
    internal class Sheep
    {
        string talk;

        public Sheep(string talk)
        {
            this.talk = talk;
        }

        public string Speaks()
        {
            return talk;
        }
    }
}