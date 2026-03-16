using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isMovingForward = false;
    float moveTimer = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.forward * 1 * Time.deltaTime;
        if (isMovingForward == true)
        {
            transform.position += transform.forward * 7 * Time.deltaTime;
            moveTimer -= Time.deltaTime;

            if (moveTimer <= 0)
            {
                isMovingForward = false;
            }
        }
    }

    public void ExitRoom()
    {
        moveTimer = 0.6f;
        isMovingForward = true;

        //while (isMovingForward == true)
        //{
        //    transform.position += transform.forward * 1 * Time.deltaTime;
        //}
        
    }
}
