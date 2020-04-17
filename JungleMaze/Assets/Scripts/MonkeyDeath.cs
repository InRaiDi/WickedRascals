using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyDeath : MonoBehaviour
{

    public Transform spawnPoint;
    int scoreZero;
    int health = 3;

    //void OnTriggerEnter2D(Collision2D other)
    //{
    //    if (other.collider.CompareTag("Player"))
    //    {
    //        other.transform.position = spawnPoint.position;
    //    }
    //}



    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        
        if (other.CompareTag("Player"))
        {

            decreaseHealth(1);
            other.transform.position = spawnPoint.position;
            
        }
        
    }

    public void decreaseHealth(int hp)
    {
        health=health-hp;
    }

}
