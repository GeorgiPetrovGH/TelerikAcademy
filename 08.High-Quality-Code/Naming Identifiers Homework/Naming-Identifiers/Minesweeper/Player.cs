namespace Minesweeper
{
    using System;
    public class Player
    {
        string name;
        int score;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player() { }

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
