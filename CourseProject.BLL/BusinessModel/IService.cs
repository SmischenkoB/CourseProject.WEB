using CourseProject.BLL.DTO;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.BLL.BusinessModel
{
    interface IService
    {
        //IUnitOfWork Database { get;     }
        void SendMessage(MessageDTO m);
        //void AddFriend(UserDTO user);
        void AddInfo(UserDTO user, InfoDTO info);
        IEnumerable<UserDTO> FindUserByInfo(InfoDTO info);
        //IEnumerable<UserDTO> GetFriends(UserDTO user);
        IEnumerable<MessageDTO> GetMessages(UserDTO user1, UserDTO user2);
        void Register(UserDTO user);
        
    }
}
