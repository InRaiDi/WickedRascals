using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public Canvas completeLevelCanvas;
    // Start is called before the first frame update
    void Start()
    {
        completeLevelCanvas.enabled = false;
    }
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            completeLevelCanvas.enabled = true;

            Invoke("RestartLevel", 3);
                
        }
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
