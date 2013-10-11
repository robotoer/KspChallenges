using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class UnaryOperation : Expression {
    public enum Type {
      Not
    }

    public readonly Type Operation;
    public readonly Expression Operand;

    public UnaryOperation(Type operation, Expression operand) {
      this.Operation = operation;
      this.Operand = operand;
    }
  }
}
