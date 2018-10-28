namespace OneClass
{
    internal class Goat
    {
        string talk;

        public Goat(string talk)
        {
            this.talk = talk;
        }

        public string Speaks()
        {
            return talk;
        }
    }
}