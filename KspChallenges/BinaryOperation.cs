using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class BinaryOperation : Expression {
    public enum Type {
      // Boolean operations.
      And,
      Or,

      // Numeric conditions.
      GreaterThan,
      LessThan,
      EqualTo
    }

    public readonly Type Operation;
    public readonly Expression Left;
    public readonly Expression Right;

    public BinaryOperation(Type operation, Expression left, Expression right) {
      this.Operation = operation;
      this.Left = left;
      this.Right = right;
    }
  }
}
