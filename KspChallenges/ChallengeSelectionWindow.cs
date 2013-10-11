using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace KspChallenges {
  /// <summary>
  /// Provides a GUI for selecting a challenge for this ship.
  /// 
  /// Basic design:
  /// - Display challenges in a list form.
  ///   - Name column
  ///   - ?Short description column
  ///   - Author column
  ///   - ?Series column (part of a larger campaign).
  ///   - Popularity/average score
  ///   - Budget
  ///   - Difficulty
  ///   - ?Recommendation
  /// - Challenge details side panel.
  ///   - Name
  ///   - Author
  ///   - Description
  ///   - ?Series (part of a larger campaign).
  ///   - Popularity/average score
  ///   - Budget
  ///   - Difficulty
  ///   - ?Recommendation
  /// 
  /// Things to add:
  /// - Support multiple challenges per ship.
  /// - Add ability to load challenges from external source (google app engine).
  /// </summary>
  class ChallengeSelectionWindow {
    /// <summary>Default coordinates for this window.</summary>
    public const Rect defaultRect = new Rect(20, 20, 120, 50);

    public ChallengeSelectionWindow() {
      // Start loading challenges.

      // Display challenges.
      GUILayout.Window(0, defaultRect, InitChallengeSelectionWindow, "Challenge Selection");
    }

    private void InitChallengeSelectionWindow(int windowId) {
      // Create challenges list.
      //   Add columns.
      //   Add scrollbar.
      //   Convert challenge to short display.

      // Create challenge details panel.
      //   Convert challenge to detail display.
    }
  }
}
