using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IMessageService
    {

        List<Message> GetListInbox(string p);
        List<Message> GetListSendbox(string p);
        void messageAdd(Message message);
        Message GetByID(int id);
        void messageDelete(Message message);
        void messageUpdate(Message message);
    }
}
