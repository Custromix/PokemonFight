using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PokemonFight.repository;

namespace PokemonFight.controllers
{
    public class UserController
    {
        private UserRepository userRepository;
        
        public UserController(User curentUser)
        {
            this.userRepository = new UserRepository(curentUser);
        }

        /// <summary>
        /// Envoie une demande d'ami à un utilisateur en vérifiant s'il existe et s'il n'est pas déjà ami
        /// </summary>
        /// <param name="nickname">type string</param>
        /// <returns>isSend Type bool</returns>
        public bool addFriend(string nickname)
        {
            bool isSend = false;
            int idFriend = this.userRepository.getPotentialFriendId(nickname);
            if (idFriend != 0)
            {
                if (!this.userRepository.isFriend(idFriend))
                {
                    this.userRepository.addFriend(idFriend);
                    isSend = true;
                }
                else
                {
                    isSend = false;
                }
            }
            else
            {
                isSend = false;
            }
            return isSend;
        }

        /// <summary>
        /// Essaye d'accepter la demande d'ami, sinon jette une exception
        /// </summary>
        /// <param name="id">Type id</param>
        /// <returns>isAccept Type bool</returns>
        /// <exception cref="Exception">Problème lors de l'acceptation de la demande d'ami</exception>
        public bool acceptFriend(int id)
        {
            bool isAccept = false;
            try
            {
                this.userRepository.acceptFriendRequest(id);
                isAccept = true;
            }
            catch (Exception e)
            {
                throw new Exception("Problème lors de l'acceptation de la demande d'ami");
            }

            return isAccept;
        }
        
        /// <summary>
        /// Essaye de refuser la demande d'ami, sinon jette une exception
        /// </summary>
        /// <param name="id">Type id</param>
        /// <returns>isReject Type bool</returns>
        /// <exception cref="Exception">Problème lors de l'acceptation de la demande d'ami</exception>
        public bool rejectFriend(int id)
        {
            bool isReject = false;
            try
            {
                this.userRepository.rejectFriendRequest(id);
                isReject = true;
            }
            catch (Exception e)
            {
                throw new Exception("Problème lors du refus de la demande d'ami");
            }

            return isReject;
        }

        /// <summary>
        /// Récupère la liste de toutes les demandes d'amis
        /// </summary>
        /// <returns>Type List<![CDATA[<User>]]></returns>
        public List<User> getAllRequest()
        {
            return this.userRepository.getAllRequest();
        }
        
        /// <summary>
        /// Récupère la liste des amis de l'utilisateur
        /// </summary>
        /// <param name="id">Type int</param>
        /// <returns>Type List<![CDATA[<User>]]></returns>
        public List<User> getAllfriends(int id)
        {
            return this.userRepository.getAllFriendId(id);
        }
        
        
    }
}