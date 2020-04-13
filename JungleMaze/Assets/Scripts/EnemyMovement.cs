using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Ememies
    public GameObject bird1;
    public GameObject bird2;
    public GameObject bird3;
    public GameObject snail1;
    public GameObject snail2;
    public GameObject snail3;

    float birdMovementSpeed = 15.0f;
    float snailMovementSpeed = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bird1.transform.position.Set(-40.0f, 21.0f, 6.787284f);
        //bird2.transform.Translate(birdMovementSpeed * Time.deltaTime, 0, 0);
        //bird3.transform.Translate(birdMovementSpeed * Time.deltaTime, 0, 0);
        //snail1.transform.Translate(snailMovementSpeed * Time.deltaTime, 0, 0);
        //snail2.transform.Translate(snailMovementSpeed * Time.deltaTime, 0, 0);
        //snail3.transform.Translate(snailMovementSpeed * Time.deltaTime, 0, 0);
        if (bird1.transform.position.x >= 11 && bird1.transform.position.y >= 21) { }
        {
            bird1.transform.Translate(0, -birdMovementSpeed * Time.deltaTime, 0);
        }
        if (bird1.transform.position.x >= 11 && bird1.transform.position.y <= 20) { }
        {
            bird1.transform.Translate(-birdMovementSpeed * Time.deltaTime, 0, 0);
        }
        if (bird1.transform.position.x <= -40 && bird1.transform.position.y <= 20) { }
        {
            bird1.transform.Translate(0, birdMovementSpeed * Time.deltaTime, 0);
        }
        if (bird1.transform.position.x >= -40 && bird1.transform.position.y >= 21) { }
        {
            bird1.transform.Translate(birdMovementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
