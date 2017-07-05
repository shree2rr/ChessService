using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessService.Models
{
    public class ChessPiece
    {
        public string id;
        public int colorId;
        public string name;
        public int[,] currentPosition;
        private string v1;
        private int v2;
        private string v3;
        private int[,] v4;

        public ChessPiece(string v1, int v2, string v3, int[,] v4)
        {
            id = v1;
            colorId = v2;
            name = v3;
            currentPosition = v4;
        }
    }
}