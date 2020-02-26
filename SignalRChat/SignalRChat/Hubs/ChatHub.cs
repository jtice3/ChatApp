using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    /// <summary>
    /// The ChatHub class inherits from the SignalR Hub class. 
    /// The Hub class manages connections, groups, and messaging.
    /// </summary>
    public class ChatHub : Hub
    {

        /// <summary>
        /// The SendMessage method can be called by a connected client to send a message to all clients. 
        /// JavaScript client code that calls the method
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        
    }
}
