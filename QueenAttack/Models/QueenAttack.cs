using System;
using System.Linq;

namespace QueenAttackNS
{
  public class QueenAttack
  {
    public int xQueen;
    public int yQueen;
    public int xOpponant;
    public int yOpponant;

    public bool QueenAttackCheck(int xQueen, int yQueen, int xOpponant, int yOpponant)
    {
      if(xQueen == xOpponant || yQueen == yOpponant)
      {
      return true;
      }
      else if(Math.Abs(xQueen - xOpponant) == Math.Abs(yQueen - yOpponant))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's check and see if the Queen chess piece can attack another piece on the board (assuming no other piece in between).");
      Console.WriteLine("Enter the which row the Queen is in:");
      Console.WriteLine("Enter the which column the Queen is in:");
      Console.WriteLine("Now enter the which row the opposing piece is in:");
      Console.WriteLine("And which column the opposing piece is in:");

    }
  }
}
