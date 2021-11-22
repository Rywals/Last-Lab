using System;

namespace Last_Lab
{
    public class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author()
        {

        }
        public Author(string tempName, char tempGender, string tempEmail)
        {
            this.name = tempName;
            this.gender = tempGender;
            this.email = tempEmail;
        }
        public void GetName(string tempName)
        {
            this.name = tempName;
        }
        public string SetName()
        {
            return name;
        }
        public void GetGender(char tempGender)
        {
            this.gender = tempGender;
        }
        public char SetGender()
        {
            return gender;
        }
        public void SetEmail(string tempEmail)
        {
            this.email = tempEmail;
        }
        public string GetEmail()
        {
            return email;
        }
        public string ToStringAuthor()
        {
            return "name = " + name + " Gender = " + gender + " email = " + email; 
        }
    }
}