﻿using CourseProject.DAL.Entenies;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private SocialNetworkContext db = new SocialNetworkContext();
        private InfoRepository infoRepository;
        private MessageRepository messageRepository;
        private UserRepository userRepository;

        public IRepository<Message> Messages
        {
            get
            {
                if (messageRepository == null)
                    messageRepository = new MessageRepository(db);
                return messageRepository;
            }
        }

        public IRepository<Info> Infos
        {
            get
            {
                if (infoRepository == null)
                    infoRepository = new InfoRepository(db);
                return infoRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
