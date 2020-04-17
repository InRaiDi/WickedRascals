using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    
    public Transform spawnPoint;
    public Transform openDoorState;
    int score;
   
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
        if (score == 18)
        {
            GameObject exitDoor = GameObject.Find("ExitDoor");
            exitDoor.transform.position = openDoorState.position;
        }
    }

   


}
