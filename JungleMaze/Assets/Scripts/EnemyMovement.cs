using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //array to keep path target points
    public Transform[] target;
    float speed;
    public bool toggleSpeedchange = true;
    bool invokeOnce = false;


    private int current;

    void Start()
    {
        if(gameObject.tag == "Bird") {
            speed = 30.0f;
        }else{
            speed = 20.0f;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speed);
        if (transform.position != target[current].position)
        {
            Vector2 pos = Vector2.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);
        }
        else
        {
            if(gameObject.tag == "Bird")
            {
                current = (current + Random.Range(0, 4)) % target.Length;
            }
            else current = (current + 1) % target.Length;

        }

        if (toggleSpeedchange == true)
        {
            if (!invokeOnce)
            {
                StartCoroutine("cycleSpeed");
                invokeOnce = true;
            }

        }
        else
        {
            if (invokeOnce)
            {
                StopCoroutine("cycleSpeed");
                invokeOnce = false;
            }
        }
    }
    //IEnumerator to creating enemies movement speed change
    IEnumerator cycleSpeed()
    {
       
        yield return new WaitForSeconds(3f);

        while (toggleSpeedchange)
        {
            speed += 10;
            yield return new WaitForSeconds(3f);
            speed -= 10;
            yield return new WaitForSeconds(3f);
        }


    }
}
