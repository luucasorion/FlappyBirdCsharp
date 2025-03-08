using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCrontoller : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    { 
        rb.velocity = Vector2.up * jumpForce;    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pontuacao")
        {
            FindObjectOfType<GameManager>().Pontuando();
        }
        else
        {
            FindObjectOfType<GameManager>().GameOver();
        }    
    }


}   
