using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    //Getting material
    private Renderer myBackground;

    //Position x offset
    private float xOffset = 0f;

    private Vector2 textureOffset;

    private float velocity = .2f;
    void Start()
    {
        myBackground = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        xOffset += Time.deltaTime * velocity;
        textureOffset.x = xOffset;
        myBackground.material.mainTextureOffset = textureOffset;
    }
}
