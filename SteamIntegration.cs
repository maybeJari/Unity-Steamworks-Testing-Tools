using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Steamworks;

public class SteamIntegration : MonoBehaviour {
    void Start() {
        try {
            SteamClient.Init(yourapplicationidhere, true);
            PrintDetails();
        }
        catch (Exception e) {
            Debug.Log(e);
        }
        SteamInventory.LoadItemDefinitions();
    }

    private void PrintDetails() {
        Debug.Log("Connected to Steam Account: " + SteamClient.Name);
        Debug.Log("Steam Account ID64: " + SteamClient.SteamId);
    }

    void Update() {
        SteamClient.RunCallbacks();
    }

    void OnApplicationQuit() {
        SteamClient.Shutdown();
    }
}
