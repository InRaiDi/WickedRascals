using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyMovement : MonoBehaviour
{
    //The monkey
    Rigidbody2D monkey;

    //speed
    float movementSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        monkey = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        actionByInput();
    }

    //Check different inputs during screen update
    void actionByInput()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {

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
            case "Lever":

                break;
        }
    }

}



