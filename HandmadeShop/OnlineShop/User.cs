using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public class User
    {
        int id;
        String firstName, lastName, mail, pass,gender;
        DateTime dateOfBirth;
        public User() { }
        public User(int id, String firstName, String lastName, String mail, String pass, DateTime dateOfBirth, String gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mail = mail;
            this.pass = pass;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

        public int getId()
        {
            return id;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String getMail()
        {
            return mail;
        }

        public DateTime getDate()
        {
            return dateOfBirth;
        }

        public String getGender()
        {
            return gender;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setMail(String mail)
        {
            this.mail = mail;
        }

        public void setPass(String pass)
        {
            this.pass = pass;
        }

        public void setGender(String gender)
        {
            this.gender = gender;
        }

        public void setDate(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
    }

}
