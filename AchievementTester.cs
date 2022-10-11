using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Sirenix.OdinInspector;
using Steamworks;
using SteamData = Steamworks.Data;

//? Testing Achievement ID
//! TESTING_ACHIEVEMENT_01
public class AchievementTester : MonoBehaviour
{
    [Title("Achievement Tester")]
    [InfoBox("Check your achievement state, unlock and clear achievements.")]
    public string AchievementID = "TESTING_ACHIEVEMENT_01";

    [Button("State")]
    [ButtonGroup("Achievement", 0.5f)]
    public void IsThisAchivementUnlocked() {
        var ach = new SteamData.Achievement(AchievementID);
        Debug.Log($"Achivement {AchievementID} state: " + ach.State);
    }

    [Button("Unlock")]
    [ButtonGroup("Achievement", 0.5f)]
    public void UnlockAchievement() {
        var ach = new SteamData.Achievement(AchievementID);
        ach.Trigger();
        Debug.Log($"Achivement {AchievementID} Unlocked!");
    }

    [Button("Clear")]
    [ButtonGroup("Achievement", 0.5f)]
    public void ClearAchievement() {
        var ach = new SteamData.Achievement(AchievementID);
        ach.Clear();
        Debug.Log($"Achivement {AchievementID} Cleared!");
    }
}
