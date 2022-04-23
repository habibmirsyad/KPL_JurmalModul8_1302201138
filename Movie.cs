namespace modul8_1302201138
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Stars { get; set; }
        public string Description { get; set; }
        public Movie(string Title, string Director, string Stars, string Description)
        {
            this.Title = Title;
            this.Director = Director;
            this.Stars = Stars;
            this.Description = Description;
        }
    }

    /*public class StarList
    {
        public string[] stars1()
        {
            string[] stars = new[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler", "Marlon Brando, Al Pacino", "James Caan", "Diane Keaton", "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" };
            return stars;
        }
        
        public string[] stars2()
        {
            string[] stars = new[] { " Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" };
            return stars;
        }

        public string[] stars3()
        {
            string[] stars = new[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" };
            return stars;
        }
        
    }*/
}
