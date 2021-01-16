using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Timer
    [SerializeField] private float timer = 1f;

    //My obstacle
    [SerializeField] private GameObject myObstacle;

    // Position to create obstacle
    [SerializeField] private Vector3 position;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(myObstacle, position, Quaternion.identity);
            timer = 1f;
        }
    }
}
