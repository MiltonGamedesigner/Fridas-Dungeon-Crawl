using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float playerReach = 10f;
    InteractableObject currentInteractable;

    // Update is called once per frame
    void Update()
    {
        CheckInteraction();
        if (Input.GetKeyDown(KeyCode.W) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    void CheckInteraction()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray, out hit, playerReach))
        {
            if (hit.collider.tag == "Interactable")
            {
                InteractableObject newInteractable = hit.collider.GetComponent<InteractableObject>();

                if (newInteractable.enabled)
                {
                    SetNewCurrentInteractable(newInteractable);
                }
                else
                {
                    DisableCurrentInteractable();
                }
            }
            else
            {
                DisableCurrentInteractable();
            }
        }
        else
        {
            DisableCurrentInteractable();
        }
    }
    void SetNewCurrentInteractable(InteractableObject newInteractable)
    {
        currentInteractable = newInteractable;
    }

    void DisableCurrentInteractable()
    {
        if (currentInteractable)
        {
            currentInteractable = null;
        }
    }
}
