using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackNS;

namespace QueenAttackTestsNS
{
  [TestClass]
  public class QueenAttackTest
  {
    public int xQueen;
    public int yQueen;
    public int xOpponant;
    public int yOpponant;

    [TestMethod]
    public void QueenAttackCheck_PieceInSameX_True()
    {
      QueenAttack newAttack = new QueenAttack();
      Assert.AreEqual(true, newAttack.QueenAttackCheck(1, 8, 1, 1));
    }
    [TestMethod]
    public void QueenAttackCheck_PieceInSameY_True()
    {
      QueenAttack newAttack = new QueenAttack();
      Assert.AreEqual(true, newAttack.QueenAttackCheck(5, 2, 1, 2));
    }
    [TestMethod]
    public void QueenAttackCheck_PieceDiagonal_True()
    {
      QueenAttack newAttack = new QueenAttack();
      Assert.AreEqual(true, newAttack.QueenAttackCheck(7, 2, 3, 6));
    }
  }
}
