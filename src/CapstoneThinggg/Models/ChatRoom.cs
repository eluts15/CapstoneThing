using System;
using System.Collections.Generic;

namespace Forum.Models
{
    public class ChatRoom
    {
        public List<User> Users;
        public List<ChatMessage> ChatHistory;

        public class ChatMessage
        {
            public User ByUser;
            public DateTime When = DateTime.Now;
            public string Message = "";
        }

        public ChatRoom()
        {
            Users = new List<User>();
            ChatHistory = new List<ChatMessage>();

            ChatHistory.Add(new ChatMessage()
            {
                Message = "joined at " + DateTime.Now
            });
        }

    }
}
