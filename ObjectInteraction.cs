using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public float interactionRange = 2f;  // Distance within which the player can interact with objects
    public Transform holdPosition;      // Position where the object will be held
    private GameObject heldObject;      // Reference to the currently held object

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldObject == null)
            {
                TryPickupObject();
            }
            else
            {
                DropObject();
            }
        }
    }

    void TryPickupObject()
    {
        // Cast a ray to detect objects in front of the player
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, interactionRange))
        {
            if (hit.collider.CompareTag("Pickup"))
            {
                PickupObject(hit.collider.gameObject);
            }
        }
    }

    void PickupObject(GameObject obj)
    {
        heldObject = obj;
        Rigidbody rb = heldObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;  // Disable physics for the held object
        }
        heldObject.transform.position = holdPosition.position;
        heldObject.transform.parent = holdPosition; // Attach to hold position
    }

    void DropObject()
    {
        if (heldObject != null)
        {
            Rigidbody rb = heldObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false; // Re-enable physics for the dropped object
            }
            heldObject.transform.parent = null; // Detach from hold position
            heldObject = null;
        }
    }
}
