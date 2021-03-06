﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    int rotateSpeed = 1;

    //door rotation
    bool rotateDoor1 = true;
    bool rotateDoor2 = true;
    //check if lever isn't pressed yet
    bool lever1 = false;
    bool lever2 = false;

    GameObject door1;
    GameObject door2;
    

    void Start()
    {
      door1 = GameObject.Find("Door1");
      door2 = GameObject.Find("Door2");
    }

    void Update()
    {
        //rotate door1 if lever1 hit
        if (lever1) {

            if (rotateDoor1)
            {
                door1.transform.Rotate(0, 0, rotateSpeed, Space.Self);
            }
            if(door1.transform.rotation.z >= 0.7f)
            {
                rotateDoor1 = false;
            }
        }
        //rotate door2 if lever2 hit
        if (lever2)
        {
            if (rotateDoor2)
            {
                door2.transform.Rotate(0, 0, rotateSpeed, Space.Self);
            }
            if (door2.transform.rotation.z >= 0.7f)
            {
                rotateDoor2 = false;
            }
            
        }

    }

    //after lever is collided, set lever hit boolean true and flip the lever 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lever1"))
        {
            lever1 = true;
            SpriteRenderer sr = other.GetComponent<SpriteRenderer>();
            sr.flipY = true;


        }

        if (other.gameObject.CompareTag("Lever2"))
        {
            lever2 = true;
            SpriteRenderer sr = other.GetComponent<SpriteRenderer>();
            sr.flipY = true;
        }
    }
}
