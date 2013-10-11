using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KspChallenges {
  /// <summary>
  /// Represents a challenge. Abstractly a challenge is defined by 3 parameters:
  /// - Win condition(s).
  /// - Constraints (for example: starting resources, mods allowed, limited time).
  /// - Reward(s).
  /// </summary>
  class Challenge {
    /// <summary>
    /// A goal is a condition (something that can be evaluated to produce a boolean value). Indicates whether
    /// or not the player has successfully completed the challenge.
    /// 
    /// At the most general level, probably some sort of turing-complete plugin system (potentially a managed
    /// .net dll, or something more secure like lua, javascript).
    /// 
    /// For simple challenges, an easier to use interface could be provided:
    /// - Support unit system
    /// - Support boolean logic basic algebra
    ///   - example: <![CDATA[(orbit.altitude > 30km) & (ship.twr < 2.4)]]>
    /// - Operations:
    ///   - Unary
    ///     - Not
    ///   - Binary
    ///     - Basic
    ///       - And
    ///       - Or
    ///     - Compound
    ///       - Xor
    /// - Common predicates(is this the right word?)
    ///   - Greater than
    ///   - Less than
    ///   - Equal to
    ///   - Within range
    ///   - ?numeric computation before thresholding (probably not)
    /// - Predicates represented as tokens (names)
    /// - Boolean operations represented by their common name (and, or, not, xor)
    /// - ?Support functions
    /// - Parenthesis, Order of operations.
    /// - Could use json/protocol buffers:
    ///   - example: <![CDATA[{ "type": "and", "parameters": [{ "type": "greaterthan", "parameters": [..."]]>
    ///   - example: <![CDATA[<and><greaterthan>...</greaterthan></and>]]>
    /// </summary>
    public readonly Expression Goal;

    /// <summary>
    /// Same representation as goal, but is interpreted as a "must be true" goal.
    /// </summary>
    public readonly Expression Constraint;

    /// <summary>
    /// Reward for the player. Could consist of one or more of the following:
    /// - Points
    /// - Achievement/Badge
    /// - Popularity in the kerbal universe
    ///   - Could be a high score board
    ///   - Could be a system that permits interaction between players
    /// </summary>
    public readonly double Reward;

    // Miscellaneous options set on a per-instance basis for tuning this challenge:
    // - Required to submit ship's .craft file
    // - Start date (real world)
    // - Expiration date (real world)
    // - Mods allowed
  }
}
