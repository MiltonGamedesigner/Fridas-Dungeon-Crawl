using Unity.Cinemachine;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    int cameraDir;
    public CinemachineCamera camN;
    public CinemachineCamera camE;
    public CinemachineCamera camS;
    public CinemachineCamera camW;

    public GameObject player;

    void Start()
    {
        cameraDir = 1;
        camN.Priority = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;

        if (cameraDir == 1)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                camN.Priority = 3;
                camE.Priority = 10;
                cameraDir = 2;
                player.transform.Rotate(0, 90, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                camN.Priority = 3;
                camW.Priority = 10;
                cameraDir = 4;
                player.transform.Rotate(0, -90, 0);
            }
        }
        else if (cameraDir == 2)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                camE.Priority = 2;
                camS.Priority = 10;
                cameraDir = 3;
                player.transform.Rotate(0, 90, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                camE.Priority = 3;
                camN.Priority = 10;
                cameraDir = 1;
                player.transform.Rotate(0, -90, 0);
            }
        }
        else if (cameraDir == 3)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                camS.Priority = 1;
                camW.Priority = 10;
                cameraDir = 4;
                player.transform.Rotate(0, 90, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                camS.Priority = 3;
                camE.Priority = 10;
                cameraDir = 2;
                player.transform.Rotate(0, -90, 0);
            }
        }
        else if (cameraDir == 4)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                camW.Priority = 0;
                camN.Priority = 10;
                cameraDir = 1;
                player.transform.Rotate(0, 90, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                camW.Priority = 3;
                camS.Priority = 10;
                cameraDir = 3;
                player.transform.Rotate(0, -90, 0);
            }
        }

        

    }
}
