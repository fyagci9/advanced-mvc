using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.List(x => x.ReceiverMail == "ks@gmail.com");
        }

        public void messageAdd(Message message)
        {
            throw new NotImplementedException();
        }

        public void messageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void messageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
