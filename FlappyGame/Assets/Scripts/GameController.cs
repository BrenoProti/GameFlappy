using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    //Points
    private float points = 0f;

    //canvas points var
    [SerializeField] private Text txtPoints;
    //canvas level var
    [SerializeField] private Text txtLevel;

    //Levels
    private int level = 1;
    [SerializeField] private float nextLevel = 8;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtLevel.text = level.ToString();
        Points();
        CreateObstacle();
        LevelUp();
    }

    private void LevelUp() 
    {
        if (points >= nextLevel) 
        {
            level++;
            nextLevel = nextLevel*2;
            Debug.Log(level);
            Debug.Log(nextLevel);
        }
    }

    private void Points()
    {
        points += Time.deltaTime;
        txtPoints.text = points.ToString();
    }

    private void CreateObstacle()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            position.y = Random.Range(posMin, posMax);

            Instantiate(myObstacle, position, Quaternion.identity);
            timer = Random.Range(1f/level, 1.5f);
        }
    }

    public int ReturnLevel()
    {
        return level;
    }
}
