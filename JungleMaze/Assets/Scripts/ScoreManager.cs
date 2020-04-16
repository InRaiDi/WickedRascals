using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public Transform spawnPoint;
    int score;
    int health = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

   
    public void ChangeScore(int coinValue)
    {
        Debug.Log(score);
        score += coinValue;
        text.text = "X" + score.ToString();
    }

    public void decreaseHealth()
    {
        health--;

        if(health <= 0)
        {
            GameObject monkey = GameObject.Find("Sylvester");
            monkey.transform.position = spawnPoint.position;
        }
    }
 

}
