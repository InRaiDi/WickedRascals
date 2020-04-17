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
    bool rotateExitDoor = false;
    GameObject exitDoor;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        exitDoor = GameObject.Find("ExitDoor");
    }

    void Update()
    {
        //rotate the exit door if collected all bananas
        if (rotateExitDoor)
        {
            exitDoor.transform.Rotate(0, 0, 1, Space.Self);
        }
        if (exitDoor.transform.rotation.z >= 0.7f)
        {
            rotateExitDoor = false;
        }
    }

    //keep noted how many bananas collected
    public void ChangeScore(int coinValue)
    {
        Debug.Log(score);
        score += coinValue;
        text.text = "X" + score.ToString();
        if (score == 18)
        {
            rotateExitDoor = true;
        }
    }

   


}
