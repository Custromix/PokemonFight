using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace PokemonFight
{
    public class User
    {
        private int idUser;
        private string name;
        private string firstname;
        private MailAddress mail;
        private string nickname;
        private string password;
        private DateTime creationDate;
        private User friends;
        private Card allCard;
        private Figthing allMatch;

        public User()
        {
            this.creationDate = DateTime.Now;
        }

        public User(string aName, string aFirsntame, string aNickname, string aMail, string aPassword)
        {
            setName(aName);
            setFirstname(aFirsntame);
            setNickname(aNickname);
            setMail(aMail);
            this.password = aPassword;
            this.creationDate = DateTime.Now;
        }

        public int IdUser { 
            get => idUser; 
            set => idUser = value; 
        }

        public string Name { 
            get => name; 
        }

        public void setName(string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                throw new Exception("Le champs nom est vide");
            }
            else
            {
                this.name = _name.ToUpper();
            }
        }

        public string Firstname { 
            get => firstname; 
        }

        public void setFirstname(string _firstname)
        {
            if (string.IsNullOrEmpty(_firstname))
            {
                throw new Exception("Le champs prenom est vide");
            }
            else
            {
                this.firstname = _firstname.Substring(0, 1).ToUpper() + _firstname.Substring(1).ToLower();
            }
        }

        public string Nickname
        {
            get => nickname;
        }
        public void setNickname(string _nickname)
        {
            if (string.IsNullOrEmpty(_nickname))
            {
                throw new Exception("Le champs identifiant ne peut pas être vide");
            }
            else
            {
                this.nickname = _nickname;
            }
        }

        public MailAddress Mail { 
            get => mail;
        }

        /* Vérifie que l'entrée correspond à un format de mail et change la valeur de mail */
        public void setMail(string mail)
        {
            try
            {
                MailAddress newAddresse = new MailAddress(mail.Trim());
                this.mail = newAddresse;
            }
            catch (Exception e)
            {
                throw new Exception("Le format du champs mail n'est pas bon");
            }
        }

        public string Password { 
            get => password;
            set => password = value;
        }

        public DateTime CreationDate { 
            get => creationDate; 
            set => creationDate = DateTime.Now;
        }

        public User Friends { 
            get => friends; 
            set => friends = value; 
        }

        public Card AllCard { 
            get => allCard; 
            set => allCard = value; 
        }

        public Figthing AllMatch
        {
            get => allMatch;
            set => allMatch = value;
        }

    }
}
