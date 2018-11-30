using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SignalRChatServer.Hubs
{
    public class SignalHub:Hub
    {
       private  IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalHub>();
        
        public  Task JoinMachineChanel (string machineID)
        {
            return hubContext.Groups.Add(Context.ConnectionId, machineID);

        }


        public Task LeaveMachineChanel(string machineID)
        {
            return Groups.Remove(Context.ConnectionId, machineID);
        }
        public override Task OnConnected()
        {
            var con = Context.ConnectionId;
            return base.OnConnected();
        }

       
        public void SendData (string machineID, String message)
        {

         
            Clients.Group(machineID).broadCastMessage(message);

        }
      

       

    }


   
}