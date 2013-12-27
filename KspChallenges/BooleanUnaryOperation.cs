using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class BooleanUnaryOperation : Expression<bool> {
    public static enum Type {
      Not
    }

    public readonly Type Operation;
    public readonly Expression<bool> Operand;

    public BooleanUnaryOperation(Type operation, Expression<bool> operand) {
      this.Operation = operation;
      this.Operand = operand;
    }

    public bool Result {
      get {
        switch (Operation) {
          case Type.Not:
            return !Operand.Result;
          default:
            throw new NotImplementedException(
                "The operation type \"" + Operation.ToString("G") + "\" is not supported.");
        }
      }
    }
  }
}
