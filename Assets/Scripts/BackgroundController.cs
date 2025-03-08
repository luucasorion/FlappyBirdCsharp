using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float speed = 2f;
    private Vector2 startPos;
    public float endScreen = -7;
    
    void Start()
    {
        startPos = transform.position;

    }
    

   
    void Update()
    {
        float movement = Time.deltaTime * speed;
        transform.position = new Vector3(transform.position.x - movement, transform.position.y);

        if (transform.position.x <= endScreen)
        {
            transform.position = startPos;
        }
    }

}

