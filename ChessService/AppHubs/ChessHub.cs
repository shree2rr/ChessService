using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using ChessService.Models;

namespace ChessService.AppHubs
{
    public class ChessHub : Hub
    {
        public void Hello()
        {
            //This is a test comment
            Clients.All.hello();
        }

        public void NotifyMoveToAll(Move move)
        {
            Clients.All.moved(move);
        }

        //public bool Join(string userName)
        //{
        //    var player = MatchStatus.Instance.GetPlayer(userName);
        //    if (player != null)
        //    {
        //        Clients.Caller.playerExists();
        //        return true;
        //    }

        //    player = MatchStatus.Instance.CreatePlayer(userName);
        //    player.ConnectionId = Context.ConnectionId;
        //    Clients.Caller.name = player.Name;
        //    Clients.Caller.hash = player.Hash;
        //    Clients.Caller.id = player.Id;

        //    Clients.Caller.playerJoined(player);

        //    return StartGame(player);
        //}
    }
}