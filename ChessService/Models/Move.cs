using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessService.Models
{
    public class Move
    {
        //public SquareContainer _sourceContainer;
        //public ChessPiece _sourceChessPiece;
        //public SquareContainer _destinationContainer ;
        //public ChessPiece _destinationChessPiece ;
        //public bool _isValid = false;
        //public string _matchId;

        public Container sourceContainer;
        public ChessPiece sourceChessPiece;
        public Container destinationContainer;
        public ChessPiece destinationChessPiece;
        public bool isValid = false;
        public string id;       
    }
}