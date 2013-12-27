using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class BooleanBinaryOperation : Expression<bool> {
    public static enum Type {
      And,
      Or
    }

    public readonly Type Operation;
    public readonly Expression<bool> Left;
    public readonly Expression<bool> Right;

    public BooleanBinaryOperation(Type operation, Expression<bool> left, Expression<bool> right) {
      this.Operation = operation;
      this.Left = left;
      this.Right = right;
    }

    public bool Result {
      get {
        switch (Operation) {
          case Type.And:
            return Left.Result && Right.Result;
          case Type.Or:
            return Left.Result || Right.Result;
          default:
            throw new NotImplementedException(
                "The operation type \"" + Operation.ToString("G") + "\" is not supported.");
        }
      }
    }
  }
}
