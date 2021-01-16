using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    [SerializeField] private float velocity = 4f;

    [SerializeField] private GameObject actualObstacle;

    // Game Controller Var
    [SerializeField] private GameController game;
    void Start()
    {
        Destroy(actualObstacle, 5f);

        game = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        //move to left
        transform.position += Vector3.left * (Time.deltaTime * velocity);
        velocity = 4f + game.ReturnLevel();


    }
}
