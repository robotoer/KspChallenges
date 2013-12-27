using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class NumericBinaryOperation : Expression<double> {
    public static enum Type {
      GreaterThan,
      LessThan,
      EqualTo
    }

    public readonly Type Operation;
    public readonly Expression<double> Left;
    public readonly Expression<double> Right;

    public NumericBinaryOperation(Type operation, Expression<double> left, Expression<double> right) {
      this.Operation = operation;
      this.Left = left;
      this.Right = right;
    }

    public bool Result {
      get {
        switch (Operation) {
          case Type.EqualTo:
            return Left.Result == Right.Result;
          case Type.GreaterThan:
            return Left.Result > Right.Result;
          case Type.LessThan:
            return Left.Result < Right.Result;
          default:
            throw new NotImplementedException(
                "The operation type \"" + Operation.ToString("G") + "\" is not supported.");
        }
      }
    }
  }
}
