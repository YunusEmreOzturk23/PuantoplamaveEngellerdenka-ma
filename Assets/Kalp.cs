using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalp : MonoBehaviour
{
    public Transform kalp2;
   void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgele = Random.Range(-6f, 6f);
        if (temas.gameObject.tag=="zemin")
        {
            kalp2.position = new Vector2(rastgele, 6f);
        }
    }
}
