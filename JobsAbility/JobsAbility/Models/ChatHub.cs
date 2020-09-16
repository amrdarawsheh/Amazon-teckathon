using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsAbility.Models
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(Messages message) => await Clients.All.SendAsync("receiveMessage", message);
    }
}
