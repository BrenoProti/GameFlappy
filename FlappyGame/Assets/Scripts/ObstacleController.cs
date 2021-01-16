using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    [SerializeField] private float velocity = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move to left
        transform.position += Vector3.left * (Time.deltaTime * velocity);
    }
}
