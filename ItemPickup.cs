using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName; // Name of the item

    private void OnTriggerEnter(Collider other)
    {
        InventorySystem inventory = other.GetComponent<InventorySystem>();
        if (inventory != null)
        {
            inventory.AddItem(itemName);
            Destroy(gameObject); // Remove the item from the scene
        }
    }
}

