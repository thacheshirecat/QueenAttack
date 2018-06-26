using System;
using System.Linq;

namespace QueenAttackNS
{
  public class QueenAttack
  {
    private int _xQueen;
    private int _yQueen;
    private int _xOpponant;
    private int _yOpponant;

    public void setXQueen(int xQueenSet)
    {
      _xQueen = xQueenSet;
    }
    public int getXQueen()
    {
      return _xQueen;
    }

    public void setYQueen(int yQueenSet)
    {
      _yQueen = yQueenSet;
    }
    public int getYQueen()
    {
      return _yQueen;
    }

    public void setXOpponant(int xOpponantSet)
    {
      _xOpponant = xOpponantSet;
    }
    public int getXOpponant()
    {
      return _xOpponant;
    }

    public void setYOpponant(int yOpponantSet)
    {
      _yOpponant = yOpponantSet;
    }
    public int getYOpponant()
    {
      return _yOpponant;
    }

    public void setCoords()
    {
      Console.WriteLine("Let's check and see if the Queen chess piece can attack another piece on the board (assuming no other piece in between).");
      Console.WriteLine("Enter the which row(X) the Queen is in:");
      setXQueen(int.Parse(Console.ReadLine()));
      Console.WriteLine("Enter the which column(Y) the Queen is in:");
      setYQueen(int.Parse(Console.ReadLine()));
      Console.WriteLine("Now enter the which row(X) the opposing piece is in:");
      setXOpponant(int.Parse(Console.ReadLine()));
      Console.WriteLine("And which column(Y) the opposing piece is in:");
      setYOpponant(int.Parse(Console.ReadLine()));
    }

    public void QueenAttackCheck(int xQueen, int yQueen, int xOpponant, int yOpponant)
    {
      if(xQueen == xOpponant || yQueen == yOpponant || (Math.Abs(xQueen - xOpponant) == Math.Abs(yQueen - yOpponant)))
      {
        Console.WriteLine("The Queen can make this attack");
      }
      else
      {
        Console.WriteLine("The Queen cannot make this attack");
      }
    }
  }

  class Program
  {
    public static void Main()
    {
      QueenAttack newAttack = new QueenAttack();
      newAttack.setCoords();
      int xQueen = newAttack.getXQueen();
      int yQueen = newAttack.getYQueen();
      int xOpponant = newAttack.getXOpponant();
      int yOpponant = newAttack.getYOpponant();
      newAttack.QueenAttackCheck(xQueen, yQueen, xOpponant, yOpponant);
    }
  }
}
