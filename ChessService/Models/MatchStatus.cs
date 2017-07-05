using ChessService.AppHubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
//using Microsoft.AspNet.SignalR.Hubs;
//using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessService.Models
{
    public class MatchStatus
    {
        //public IHubConnectionContext Clients { get; set; }
        public IGroupManager Groups { get; set; }
        public IHubConnectionContext<dynamic> Clients { get; private set; }

        private static readonly Lazy<MatchStatus> _instance = new Lazy<MatchStatus>(
           () => new MatchStatus(GlobalHost.ConnectionManager.GetHubContext<ChessHub>()));

        private IHubContext hubContext;

        public MatchStatus(IHubContext hubContext)
        {
            Clients = hubContext.Clients;
            Groups = hubContext.Groups;

        }

        public static MatchStatus Instance
        {
            get { return _instance.Value; }
        }


      





    }
}