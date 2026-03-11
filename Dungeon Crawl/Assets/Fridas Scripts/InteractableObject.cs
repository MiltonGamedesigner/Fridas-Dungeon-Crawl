using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public UnityEvent onInteraction;

    public void Interact()
    {
        onInteraction.Invoke();
    }


}
