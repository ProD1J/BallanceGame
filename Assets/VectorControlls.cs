using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorControlls : MonoBehaviour
{
    public GameObject PlayerVector;
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerVector.transform.position = player.position + offset;
        if(Input.GetKeyDown(KeyCode.Q))
        {
            PlayerVector.transform.Rotate(0, 90.0f, 0, Space.World);
            if (offset == new Vector3(0.0f, 8.0f, -8.0f))
                offset = new Vector3(-8.0f, 8.0f, 0.0f);
            else if(offset == new Vector3(-8.0f, 8.0f, 0.0f))
                offset = new Vector3(0.0f, 8.0f, 8.0f);
            else if (offset == new Vector3(0.0f, 8.0f, 8.0f))
                offset = new Vector3(8.0f, 8.0f, 0.0f);
            else if (offset == new Vector3(8.0f, 8.0f, 0.0f))
                offset = new Vector3(0.0f, 8.0f, -8.0f);
            else
                offset = new Vector3(0.0f, 8.0f, -8.0f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerVector.transform.Rotate(0, -90.0f, 0, Space.World);
            if (offset == new Vector3(0.0f, 8.0f, -8.0f))
                offset = new Vector3(8.0f, 8.0f, 0.0f);
            else if(offset == new Vector3(8.0f, 8.0f, 0.0f))
                offset = new Vector3(0.0f, 8.0f, 8.0f);
            else if (offset == new Vector3(0.0f, 8.0f, 8.0f))
                offset = new Vector3(-8.0f, 8.0f, 0.0f);
            else if (offset == new Vector3(-8.0f, 8.0f, 0.0f))
                offset = new Vector3(0.0f, 8.0f, -8.0f);
            else
                offset = new Vector3(0.0f, 8.0f, -8.0f);
        }
    }
}
