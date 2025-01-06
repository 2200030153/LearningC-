using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animator doorAnimator; // Animator component for door animation
    public string openAnimationName = "DoorOpen";
    public string closeAnimationName = "DoorClose";
    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractWithDoor();
        }
    }

    private void InteractWithDoor()
    {
        if (doorAnimator == null)
        {
            Debug.LogWarning("Door Animator is not assigned!");
            return;
        }

        if (isOpen)
        {
            doorAnimator.Play(closeAnimationName);
            Debug.Log("Door Closed");
        }
        else
        {
            doorAnimator.Play(openAnimationName);
            Debug.Log("Door Opened");
        }

        isOpen = !isOpen;
    }
}
