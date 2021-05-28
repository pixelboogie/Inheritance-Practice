namespace CSharp_Inheritance
{
    class Movie : MediaType
    {
        public readonly string Director;

          
        public Movie(string title, string director) 
        : base(title)
        {
            Director = director;
        }

                public string GetDisplayText()
        {
            string text = "Movie: " + Title + " by " + Director;
            
            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text += " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on loan)";
                }                
            }
            
            return text;
        }
    }
}