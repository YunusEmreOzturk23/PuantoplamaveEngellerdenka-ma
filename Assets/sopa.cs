using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sopa : MonoBehaviour
{
    public Transform sopa2;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgele = Random.Range(-6f, 6f);
        if (temas.gameObject.tag=="zemin")
        {
            sopa2.position = new Vector2(rastgele, 6f);
        }
       
    }
}
