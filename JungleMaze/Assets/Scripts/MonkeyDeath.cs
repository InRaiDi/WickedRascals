using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MonkeyDeath : MonoBehaviour
{

    public Transform spawnPoint;
    public TextMeshProUGUI text;
    int health = 3;





    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        string otherTag = other.gameObject.tag;
        
        if (otherTag == "Player")
        {
            if (gameObject.tag == "Bird") { decreaseHealth(1); }
            if (gameObject.tag == "Snail") { decreaseHealth(2); }

            if (health <= 0)
            {
                SceneManager.LoadScene(0);
            }         
        }
    }

    public void decreaseHealth(int hp)
    {
        health -= hp;
        text.text = "X" + health.ToString();
    }

}
