using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonFight.security;
using PokemonFight.repository;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace PokemonFight.controllers
{
    class AuthenticatorController
    {
        private User newUser;
        private User userConnected;
        private UserAuthenticator authentification;
        private UserRepository crudUser;

        public AuthenticatorController()
        {
            this.authentification = new UserAuthenticator();
        }

        public void setController(User _user)
        {
            this.newUser = _user;
            this.crudUser = new UserRepository(_user);
        }
        
        /// <summary>
        /// Renvoie true si un utilisateur est enregistrer false sinon
        /// </summary>
        /// <param name="code">Type string</param>
        /// <returns>var isRegister Type bool</returns>
        /// <exception cref="Exception">Une erreur s'est produite lors de l'enregistrement du compte, veuillez réessayer !</exception>
        public bool register(string code)
        {
            bool isRegister;
            if (this.authentification.isExist(this.newUser))
            {
                throw new Exception("Le nom d'utilisateur ou l'email est déjà utilisé");
            }else
            {
                try
                {
                    if (!string.IsNullOrEmpty(code))
                    {
                        int idSponsor = this.crudUser.getUserBySponsorshipCode(code);
                        if (idSponsor != -1)
                        {
                            this.newUser.IdUserBeSponsored = idSponsor;
                            this.crudUser.setUser(this.newUser);
                        }
                    }
                    this.crudUser.insert();
                    isRegister = true;
                }
                catch(Exception e)
                {
                    isRegister = false;
                    
                    throw new Exception(e.ToString());/*"Une erreur s'est produite lors de l'enregistrement du compte, veuillez réessayer !"*/
                }
            }
            return isRegister;
        }
        
        /// <summary>
        /// Renvoie true si l'utilisateur est parvenu à se connecté et instancie l'utilisateur current false sinon
        /// </summary>
        /// <returns>var isLoged Type bool</returns>
        public bool login()
        {
            bool isLoged;
            User potentialUser = this.authentification.getPotentialLogUser(this.newUser);
            if (potentialUser.IdUser != 0)
            {
                if (BC.Verify(this.newUser.Password, potentialUser.Password))
                {
                    this.userConnected = potentialUser;
                    isLoged = true;
                }
                else
                {
                    isLoged = false;
                }
            }
            else
            {
                isLoged = false;
            }
           
            return isLoged;
        }

        public User getUser()
        {
            return this.userConnected;
        }

    }
}
