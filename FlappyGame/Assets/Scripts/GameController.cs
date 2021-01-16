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

    //Min and Max position in y to create obstacle
    [SerializeField] private float posMin = -1.8f;
    [SerializeField] private float posMax = 0.78f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            position.y = Random.Range(posMin, posMax);

            Instantiate(myObstacle, position, Quaternion.identity);
            timer = Random.Range(1f, 2f);
        }
    }
}
