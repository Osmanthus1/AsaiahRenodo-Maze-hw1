using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.Getkey(KeyCode.D))
        {
            newPos.x++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x--;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.y--;
        }
        if (Input.GetKey(KeyCode.W))
        {
            newPos.y++;
        }
        transform.position = newPos;
    }
}
