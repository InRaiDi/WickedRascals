using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lever1"))
        {
            var door1 = GameObject.Find("Door1");
            door1.transform.position = new Vector2(-23.24f, 3.08f);
        
        }

        if (other.gameObject.CompareTag("Lever2"))
        
        {
          var door2 = GameObject.Find("Door2");
          door2.transform.position = new Vector2(26.86f, -27.79f);

        }
    }
}
