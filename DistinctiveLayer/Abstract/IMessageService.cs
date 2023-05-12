using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Abstract
{
     public interface IMessageService
    {
        List<Message> GetList();
        Message GetMessageById(int id);

        void AddMessage(Message message);

        void DeleteMessage(Message message);

        void UpdateMessage(Message message);
    }
}
