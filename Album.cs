namespace CSharp_Inheritance
{
    class Album : MediaType
    {

        public readonly string Artist;

        
        public Album(string title, string artist) 
        : base(title)
        {
            Artist = artist;
        }
        
        
        public string GetDisplayText()
        {
            string text = "Album: " + Title + " by " + Artist;
            
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













