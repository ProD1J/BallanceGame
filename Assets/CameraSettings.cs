using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float timeToReach;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Camera.main.transform.LookAt(player.position);
        Camera.main.transform.position = Vector3.SmoothDamp((Camera.main.transform.position), (player.position + offset),ref velocity, timeToReach);
    }
    void Update()
    {
        //Camera.main.transform.LookAt(player.position);
        //Camera.main.transform.position =Vector3.MoveTowards((Camera.main.transform.position) , (player.position + offset), speed);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Camera.main.transform.Rotate(0, 90.0f, 0, Space.World);
            if (offset == new Vector3(0.0f, 6.0f, -6.0f))
                offset = new Vector3(-6.0f, 6.0f, 0.0f);
            else if (offset == new Vector3(-6.0f, 6.0f, 0.0f))
                offset = new Vector3(0.0f, 6.0f, 6.0f);
            else if (offset == new Vector3(0.0f, 6.0f, 6.0f))
                offset = new Vector3(6.0f, 6.0f, 0.0f);
            else if (offset == new Vector3(6.0f, 6.0f, 0.0f))
                offset = new Vector3(0.0f, 6.0f, -6.0f);
            else
                offset = new Vector3(0.0f, 6.0f, -6.0f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Camera.main.transform.Rotate(0, -90.0f, 0, Space.World);
            if (offset == new Vector3(0.0f, 6.0f, -6.0f))
                offset = new Vector3(6.0f, 6.0f, 0.0f);
            else if (offset == new Vector3(6.0f, 6.0f, 0.0f))
                offset = new Vector3(0.0f, 6.0f, 6.0f);
            else if (offset == new Vector3(0.0f, 6.0f, 6.0f))
                offset = new Vector3(-6.0f, 6.0f, 0.0f);
            else if (offset == new Vector3(-6.0f, 6.0f, 0.0f))
                offset = new Vector3(0.0f, 6.0f, -6.0f);
            else
                offset = new Vector3(0.0f, 6.0f, -6.0f);
        }
    }
}
