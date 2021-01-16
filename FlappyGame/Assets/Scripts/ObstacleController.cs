using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    [SerializeField] private float velocity = 5f;

    [SerializeField] private GameObject actualObstacle;
    void Start()
    {
        Destroy(actualObstacle, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //move to left
        transform.position += Vector3.left * (Time.deltaTime * velocity);
    }
}
