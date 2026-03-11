using UnityEngine;
using UnityEngine.Events;

public class InteractableScript : MonoBehaviour
{
    public UnityEvent onInteraction;

    public void Interact()
    {
        onInteraction.Invoke();
    }

    
}
