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
    public const Rect DefaultRect = new Rect(20, 20, 120, 50);
    public readonly List<Challenge> Challenges;

    public ChallengeSelectionWindow() {
      // Start loading challenges.
      this.Challenges = new List<Challenge>() {
        //new Challenge(new Predicate("ship.altitude"), new Predicate("ship.altitude"), 10.0)
      };

      // Display challenges.
      GUILayout.Window(0, DefaultRect, OnGui, "Challenge Selection");
    }

    private void OnGui(int windowId) {
      Vector2 scrollPosition = new Vector2();

      // Create challenges list.
      GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(640.0f), GUILayout.Height(480.0f));

      // Add columns.
      // Add scrollbar.
      // Convert challenge to short display.
      foreach (Challenge challenge in Challenges) {
        if (GUILayout.Button(challenge.Name))
          ;
      }

      // Create challenge details panel.
      //   Convert challenge to detail display.
    }
  }
}
