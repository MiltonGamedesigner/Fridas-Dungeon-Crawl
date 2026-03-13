using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{

    public PlayerMovement pm;
    
    public void DoorProgress()
    {
        pm.ExitRoom();
    }
}
