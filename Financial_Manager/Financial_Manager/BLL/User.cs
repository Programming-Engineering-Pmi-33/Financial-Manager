using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager.BLL
{
    class User
    {
        int Id { get; }
        string Name { set; get; }
        string Surname { set; get; }
        string Occupation { set; get; }
        byte[] Photo { set; get; }
        Currency DefaultCurrency { set; get; }
        Language DefaultLanguage { set; get; }
        string Username { set; get; }
        string Password { set; get; }
        string Salt { set; get; }

        public User(int id, string name, string surname, Currency defaultCurrency, Language defaultLanguage, 
            string username,  string password, string salt, string occupation = null, byte[] photo = null)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Occupation = occupation;
            Photo = photo;
            DefaultCurrency = defaultCurrency;
            DefaultLanguage = defaultLanguage;
            Username = username;
            Password = password;
            Salt = salt;
        }

        public void UpdateUserSettings(string name, string surname, Currency defaultCurrency, Language defaultLanguage,
             string password, string occupation = null, byte[] photo = null)
        {
            Name = name;
            Surname = surname;
            Occupation = occupation;
            Photo = photo;
            DefaultCurrency = defaultCurrency;
            DefaultLanguage = defaultLanguage;
            Password = password;
        }
    }
}
