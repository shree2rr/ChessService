using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessService.Models
{
    public class Container
    {
        string matchId;
        public int[,] position;
        public ChessPiece chessPiece;

        public Container(string _id, int[,] _position , ChessPiece _chessPiece )
        {
            matchId = _id;
            position = _position;
            chessPiece = _chessPiece;
        }
    }
}