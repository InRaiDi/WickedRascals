using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyMovement : MonoBehaviour
{
   

    //speed
    public float movementSpeed = 50.0f;
    bool rotation = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        actionByInput();
    }

    //Check different inputs during screen update
    void actionByInput()
    {
        //Move up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        }
        //Move down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
        }
        //Move left
        if (Input.GetKey(KeyCode.A))
        {
            //check if not rotated, rotate
            if (!rotation)
            {
                transform.Rotate(0, 180.0f, 0.0f, Space.Self);
                rotation = true;
            }
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
        //Move right
        if (Input.GetKey(KeyCode.D))
        {
            //check if rotated, unrotate
            if (rotation)
            {
                transform.Rotate(0, 180.0f, 0.0f, Space.Self);
                rotation = false;
            }
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string coll = collision.gameObject.tag;

        switch (coll)
        {
            case "Banana":
                Destroy(collision.gameObject);
                break;
            default:
                break;
        }
    }

}



