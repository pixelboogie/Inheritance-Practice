using System;

namespace CSharp_Inheritance
{
    class MediaType
    {
        public string Title;
        public string Loanee;
        public bool OnLoan;

        public MediaType(string title){

            if(string.IsNullOrEmpty(title))
            {
                throw new Exception("A media type must have a title.");
            }

            Title = title;

        }
                public void Loan()
        {
            OnLoan = true;
        }
        
        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }
        
        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }

}
