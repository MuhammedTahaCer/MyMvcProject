using DataAccess.Abstract;
using DistinctiveLayer.Abstract;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctiveLayer.Concrate
{
    public class MessageManager :IMessageService
    {
        IMessageDL _message;

        public MessageManager(IMessageDL message)
        {
            _message = message;
        }

        public void AddMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _message.FilterList(x => x.receiverMail == "cermuhammed720@gmail.com");
        }

        public Message GetMessageById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
