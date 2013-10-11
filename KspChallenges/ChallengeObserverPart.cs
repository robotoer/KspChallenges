using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace KspChallenges {
  class ChallengeObserverPart : PartModule {
    public override void OnStart(PartModule.StartState state) {
      switch (state) {
        case StartState.Editor:
          // Create the challenge selection window.
          new ChallengeSelectionWindow();
          break;
        case StartState.PreLaunch:
        case StartState.Flying:
        case StartState.SubOrbital:
        case StartState.Orbital:
        case StartState.Landed:
        case StartState.Splashed:
        case StartState.Docked:
          // Display current challenge progress.
          break;
        case StartState.None:
          // Error maybe?
          break;
      }

      // Create the style settings for a GUI button.
      GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
      buttonStyle.normal.textColor = Color.white;
      buttonStyle.focused.textColor = Color.white;
      buttonStyle.hover.textColor = Color.yellow;
      buttonStyle.active.textColor = Color.yellow;
      buttonStyle.onNormal.textColor = Color.green;
      buttonStyle.onFocused.textColor = Color.green;
      buttonStyle.onHover.textColor = Color.green;
      buttonStyle.onActive.textColor = Color.green;
      buttonStyle.padding = new RectOffset(8, 8, 8, 8);

      // Display
      GUILayout.BeginVertical();
      GUILayout.EndVertical();
      base.OnStart(state);
    }
  }
}
