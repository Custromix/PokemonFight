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
        private int idUserBeSponsored;
        private string name;
        private string firstname;
        private MailAddress mail;
        private string nickname;
        private string sponsorshipCode;
        private string password;
        private DateTime creationDate;
        private int xp;
        private int money;
        private User friends;
        private List<Card> allCard;
        private List<Figthing> allMatch;

        public User()
        {
            this.creationDate = DateTime.Now;
            this.allCard = new List<Card>();
            this.allMatch = new List<Figthing>();
        }

        public User(string aName, string aFirsntame, string aNickname, string aMail, string aPassword)
        {
            setName(aName);
            setFirstname(aFirsntame);
            setNickname(aNickname);
            setMail(aMail);
            this.password = aPassword;
            this.creationDate = DateTime.Now;
            this.xp = 0;
            this.money = 500;
            this.allCard = new List<Card>();
            this.allMatch = new List<Figthing>();
        }

        public int IdUser { 
            get => idUser; 
            set => idUser = value; 
        }

        public int IdUserBeSponsored
        {
            get => idUserBeSponsored;
            set => idUserBeSponsored = value;
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

        public string SponsorshipCode
        {
            get => sponsorshipCode;
        }

        public void setSponsorshipCode()
        {
            this.sponsorshipCode = this.Firstname.Substring(0,1) + this.IdUser + this.CreationDate.Year + this.CreationDate.Month + this.CreationDate.Day + this.Name.Substring(0,1);
        }

        public MailAddress Mail 
        { 
            get => mail;
        }

        /// <summary>
        /// Vérifie que l'entrée correspond à un format de mail et change la valeur de mail
        /// </summary>
        /// <param name="mail">Type string</param>
        /// <exception cref="Exception">Le format du champs mail n'est pas bon !</exception>
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

        public int Xp
        {
            get => xp;
            set => xp = value;
        }

        public int Money
        {
            get => money;
            set => money = value;
        }

        public User Friends { 
            get => friends; 
            set => friends = value; 
        }

        public List<Card> getAllCard()
        {
            return this.allCard;
        }

        public void addCard(Card aCard)
        {
            this.allCard.Add(aCard);
        }

        public void removeCard(Card aCardRemoved)
        {
            if (this.allCard.Contains(aCardRemoved))
            {
                this.allCard.Remove(aCardRemoved);
            }
        }

        public List<Figthing> AllMatch
        {
            get => allMatch;
        }
        
        public void addMatch(Figthing afight)
        {
            this.allMatch.Add(afight);
        }
        
        
    }
}
