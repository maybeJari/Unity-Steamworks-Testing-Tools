using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Sirenix.OdinInspector;
using Steamworks;

public class InventoryTester : MonoBehaviour {
    [Title("Inventory Tester")]
    [InfoBox("Generate and Remove Items on your Steam Inventory.")]
    public int itemID = 100;
    public int itemAmount = 1;

    [Button("Generate Item")]
    [ButtonGroup("Inventory", 0.5f)]
    public void GenerateItemAsync() {
        var itemDef = SteamInventory.FindDefinition(itemID);
        var inventoryResult = SteamInventory
            .GenerateItemAsync(itemDef, itemAmount)
            .Result;
        Debug.Log($"{itemAmount} of {itemID} has been generated.");
    }

    [Button("Remove Item")]
    [ButtonGroup("Inventory", 0.5f)]
    public void ItemRemove() {
        //  Debug.Log($"{itemAmount} of {itemID} has been removed from the inventory.");
        Debug.Log($"Currently not Supported.");
    }
}
