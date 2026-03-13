using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isMovingForward = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 1 * Time.deltaTime;
        if (isMovingForward == true)
        {
            transform.position += transform.forward * 1 * Time.deltaTime;
        }
    }

    public void ExitRoom()
    {
        isMovingForward = true;

        while (isMovingForward == true)
        {
            transform.position += transform.forward * 1 * Time.deltaTime;
        }
        
    }
}
