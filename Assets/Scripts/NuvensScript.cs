using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class NuvensScript : MonoBehaviour
{
    public float velocidade = 3f;
    private float bordaEsquerda;
    void Start()
    { 
        bordaEsquerda = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 16f;         
    }
   
    
    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
        if (transform.position.x < bordaEsquerda)
        {
            Destroy(gameObject);
        }    
    }
}
