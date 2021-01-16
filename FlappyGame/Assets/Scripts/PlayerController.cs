using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Geting the Rigidbody 
    private Rigidbody2D myRB;
    // speed of fly
    [SerializeField] private float velocity = 5f;
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Making the player fly by pressing spacebar
        Fly();

        //limiting the speed of fall
        LimitingVelocity();
    }

    //Method to limit the speed of fall
    private void LimitingVelocity()
    {
        if (myRB.velocity.y < -velocity)
        {
            myRB.velocity = Vector2.down * velocity;
        }
    }

    //Method to make the plane fly
    public void Fly()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRB.velocity = Vector2.up * velocity;
        }
    }

    //configuring collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
