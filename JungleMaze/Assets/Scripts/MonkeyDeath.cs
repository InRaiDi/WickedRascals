using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MonkeyDeath : MonoBehaviour
{

    public Transform spawnPoint;
    public TextMeshProUGUI text;
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

            if (gameObject.tag == "bird") { decreaseHealth(1); }
            if (gameObject.tag == "snail") { decreaseHealth(2); }

            other.transform.position = spawnPoint.position;
            
        }
        
    }

    public void decreaseHealth(int hp)
    {
        health=health-hp;
        text.text = "X" + health.ToString();
    }

}
