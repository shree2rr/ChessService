using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessService.Models
{
    public class StoryLine
    {
        string id;
        string matchId;
        List<Message> messages;
    }
    public class Message
    {
        string id;
        string message;
    }
}