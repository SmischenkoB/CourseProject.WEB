using CourseProject.BLL.DTO;
using CourseProject.DAL.Entenies;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CourseProject.BLL.BusinessModel
{
    class SocialService : IService
    {
        private IUnitOfWork Database { get; set; }

        public SocialService(IUnitOfWork unit)
        {
            Database = unit;
        }

        public void SendMessage(MessageDTO message)
        {
            Message mes = new Message
            {
                Id = message.Id,
                Text = message.Text,
                User1 = message.User1,
                User2 = message.User2
            };

            Database.Messages.Create(mes);

            Database.Users.Get(message.User1).Messages.Add(mes);
            Database.Users.Get(message.User2).Messages.Add(mes);
            Database.Save();
        }
        

        public void AddInfo(UserDTO user, InfoDTO info)
        {
            User u = Database.Users.Get(user.Id);
            //if (u.Info == null) return;
            u.Info = new Info() { City = info.City, User = u };
            Database.Infos.Create(u.Info);
            Database.Save();
        }

        public IEnumerable<UserDTO> FindUserByInfo(InfoDTO info)
        {
            
            Info insideInfo = new Info() { City = info.City };
            List<UserDTO> output = new List<UserDTO>();
            IEnumerable<User> users = Database.Users.GetAll().Where(u => u.Info.Equals(insideInfo));
            foreach (var item in users)
            {
                var udto = new UserDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Phone = item.Phone,
                    Info = item.Info.Id
                    //Role = item.Roles.ToArray(). }
                };
                udto.Role = new int[item.Roles.Count];
                
                for (int i = 0; i < udto.Role.Length; i++)
                {
                    udto.Role[i] = item.Roles.ToArray()[i].Id;
                }
                output.Add(udto);
            }
            

            
            return output;
            //throw new NotImplementedException();
        }
        
        public IEnumerable<MessageDTO> GetMessages(UserDTO user1, UserDTO user2)
        {
            List<MessageDTO> output = new List<MessageDTO>();
            foreach (var item in Database.Messages.GetAll().
                Where(u => (u.User1 == user1.Id && u.User2 == user2.Id) ||
                (u.User1 == user1.Id && u.User2 == user2.Id)))
            {
                output.Add(new MessageDTO
                {
                    Id = item.Id,
                    Text = item.Text,
                    User1 = item.User1,
                    User2 = item.User2
                });
            }

            return output;
            
        }

        public IEnumerable<UserDTO> GetChats(UserDTO user1)
        {
            HashSet<UserDTO> output = new HashSet<UserDTO>();
            var messages = Database.Messages.GetAll().Where(u => u.User1 == user1.Id 
            || u.User2 == user1.Id);

            //getting list of users having messagies with this user
           //foreach (var item in Database.)
           //{
           //    Set
           //}

            return output;
        }

        public void Register(UserDTO user)
        {
            User u = new User();
            u.Name = user.Name;
            u.Password = user.Password;
            u.Roles.Add(Database.Roles.Find(r => r.RoleName == "user").First());
            Database.Users.Create(u); 
            throw new NotImplementedException( );
        }
    }
}
