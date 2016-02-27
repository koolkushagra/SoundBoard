using SoundBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundBoard.Data
{
    public class MessageRepository
    {
        private static readonly List<Message> Messages = new List<Message>();
        private static int IdCount = 0;
        private const string UserIdOne = "48999b9d-8116-472b-99fa-4a8793ea1c57";
        private const string UserIdTwo = "5d895f79-ffb1-4486-ba95-83d7a280ea0f";

        static MessageRepository()
        {
            Messages.Add(new Message
            {
                Id = GetNextId(),
                UserId = UserIdOne,
                Created = new DateTime(2015, 6, 1),
                MessageTitle = "First Message",
                MessageContent = "This is the first message"
            });

            Messages.Add(new Message
            {
                Id = GetNextId(),
                UserId = UserIdOne,
                Created = new DateTime(2015, 6, 2),
                MessageTitle = "Second Message",
                MessageContent = "Hi Mom!"
            });

            Messages.Add(new Message
            {
                Id = GetNextId(),
                UserId = UserIdTwo,
                Created = new DateTime(2015, 6, 3),
                MessageTitle = "Third Message",
                MessageContent = "Hello, ASP.NET MVC 6!"
            });
        }

        public IEnumerable<Message> GetAll()
        {
            return Messages.ToArray();
        }

        public Message GetBy(int id)
        {
            return Messages.SingleOrDefault(m => m.Id == id);
        }

        public void Update(Message message)
        {
            // TODO: nothing
        }

        public void Add(Message message)
        {
            message.Id = GetNextId();
            Messages.Add(message);
        }

        private static int GetNextId()
        {
            return ++IdCount;
        }
    }
}
