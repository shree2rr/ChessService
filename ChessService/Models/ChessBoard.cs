using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessService.Models
{
    public class ChessBoard
    {
        public Container[,] _squareContainer;
        public string _matchId;

        public ChessBoard(string id)
        {
            _matchId = id;
            InitializeChessBoard(_squareContainer);
        }

        private void InitializeChessBoard(Container[,] squareContainer)
        {
            InitializeAllContainers(squareContainer);
        }

        private void  InitializeAllContainers(Container[,] squareContainer)
        {
            if (squareContainer == null)
            {
                for (int i = 0; i < 8; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {
                        int[,] position;
                        position = new int[1, 2] { { i, j } };
                        squareContainer[i, j] = new Container(_matchId, position, null);
                    }
                }
            }
            _squareContainer =  squareContainer;
        }

        public void InitializeChessPieces()
        {
            List<ChessPiece> _chessPieces = new List<ChessPiece>();

            _chessPieces.AddRange(new List<ChessPiece> { 
              //Initialize white chessman
              new  ChessPiece("w1", 1, "rook", new int[1, 2] { { 0,0} }),
      new ChessPiece("w2", 1, "knight", new int[1, 2] {{0, 1}}),
      new ChessPiece("w3", 1, "bishop", new int[1, 2] {{0, 2}}),
      new ChessPiece("w4", 1, "king", new int[1, 2] {{0, 3}}),
      new ChessPiece("w5", 1, "queen", new int[1, 2] {{0, 4}}),
      new ChessPiece("w6", 1, "bishop", new int[1, 2] {{0, 5}}),
      new ChessPiece("w7", 1, "knight", new int[1, 2] {{0, 6}}),
      new ChessPiece("w8", 1, "rook", new int[1, 2] {{0, 7}}),
      new ChessPiece("w9", 1, "pawn", new int[1, 2] {{1, 0}}),
      new ChessPiece("w10", 1, "pawn", new int[1, 2] {{1, 1}}),
      new ChessPiece("w11", 1, "pawn", new int[1, 2] {{1, 2}}),
      new ChessPiece("w12", 1, "pawn", new int[1, 2] {{1, 3}}),
      new ChessPiece("w13", 1, "pawn", new int[1, 2] {{1, 4}}),
      new ChessPiece("w14", 1, "pawn", new int[1, 2] {{1, 5}}),
      new ChessPiece("w15", 1, "pawn", new int[1, 2] {{1, 6}}),
      new ChessPiece("w16", 1, "pawn", new int[1, 2] {{1, 7}}),

      //Initialize black chessman 
      new ChessPiece("b1", 2, "rook", new int[1, 2] {{7, 7}}),
      new ChessPiece("b2", 2, "knight", new int[1, 2] {{7, 6}}),
      new ChessPiece("b3", 2, "bishop", new int[1, 2] {{7, 5}}),
      new ChessPiece("b4", 2, "king", new int[1, 2] {{7, 4}}),
      new ChessPiece("b5", 2, "queen", new int[1, 2] {{7, 3}}),
      new ChessPiece("b6", 2, "bishop", new int[1, 2] {{7, 2}}),
      new ChessPiece("b7", 2, "knight", new int[1, 2] {{7, 1}}),
      new ChessPiece("b8", 2, "rook", new int[1, 2] {{7, 0}}),
      new ChessPiece("b9", 2, "pawn", new int[1, 2] {{6, 7}}),
      new ChessPiece("b10", 2, "pawn", new int[1, 2] {{6, 6}}),
      new ChessPiece("b11", 2, "pawn", new int[1, 2] {{6, 5}}),
      new ChessPiece("b12", 2, "pawn", new int[1, 2] {{6, 4}}),
      new ChessPiece("b13", 2, "pawn", new int[1, 2] {{6, 3}}),
      new ChessPiece("b14", 2, "pawn", new int[1, 2] {{6, 2}}),
      new ChessPiece("b15", 2, "pawn", new int[1, 2] {{6, 1}}),
      new ChessPiece("b16", 2, "pawn", new int[1, 2] {{6, 0}})
            }

    );


        }



    }
}