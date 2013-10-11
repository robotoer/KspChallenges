using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class Literal : Expression {
    enum Unit {
      KiloMeters,
      Meters,
      MetersPerSecond,
      SpecificImpulse,
      KiloNewtons,
      Seconds,
      None
    }

    public readonly double Value;
    public readonly Unit Units;

    public Literal(double value, Unit units) {
      this.Value = value;
      this.Units = units;
    }
  }
}
