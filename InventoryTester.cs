using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Sirenix.OdinInspector;

public class InventoryTester : MonoBehaviour
{
    [Title("Inventory Tester")]
    [InfoBox("Generate and Remove Items in your Steam Inventory.")]
    public int itemID = 100;
    public int itemAmount = 1;

    [Button("Generate Item")]
    [ButtonGroup("Inventory", 0.5f)]
    public void GenerateItemAsync()
    {
    Steamworks.SteamInventory.LoadItemDefinitions();
    var itemDef = Steamworks.SteamInventory.FindDefinition( itemID );
    var inventoryResult = Steamworks.SteamInventory.GenerateItemAsync( itemDef, itemAmount ).Result;
    Debug.Log($"{itemAmount} of {itemID} has been generated.");
    }

    [Button("Remove Item")]
    [ButtonGroup("Inventory", 0.5f)]
    public void ItemRemove() {
    Debug.Log($"Removing Items Currently not Implemented.");
    }
}
