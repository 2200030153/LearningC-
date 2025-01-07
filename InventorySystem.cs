using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<string> inventory = new List<string>(); // List to store items

    // Add an item to the inventory
    public void AddItem(string itemName)
    {
        inventory.Add(itemName);
        Debug.Log($"Added {itemName} to inventory.");
    }

    // Remove an item from the inventory
    public void RemoveItem(string itemName)
    {
        if (inventory.Contains(itemName))
        {
            inventory.Remove(itemName);
            Debug.Log($"Removed {itemName} from inventory.");
        }
        else
        {
            Debug.LogWarning($"{itemName} is not in the inventory.");
        }
    }

    // Display all items in the inventory
    public void ShowInventory()
    {
        Debug.Log("Inventory Contents:");
        if (inventory.Count == 0)
        {
            Debug.Log("Inventory is empty.");
        }
        else
        {
            foreach (var item in inventory)
            {
                Debug.Log($"- {item}");
            }
        }
    }
}
