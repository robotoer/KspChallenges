﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  class Predicate : Expression<double> {
    public readonly string Name;

    public Predicate(string name) {
      this.Name = name;
    }

    public double Result {
      get { throw new NotImplementedException(); }
    }
  }
}
