using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class karakterHareketi : MonoBehaviour
{
    public float hiz; 
    public Transform kalp,sopa;
    int puan,can=3;
    public TextMeshProUGUI PuanYazisi,canYazisi,bitisYazisi;
    void Start()
    {
        
    }
    void Update()
    {
        PuanYazisi.text = "Puan: " + puan;
        canYazisi.text = "Can: " + can;
        if (can == 0)
        {
            bitisYazisi.text = "Oyun Bitti \n Yeniden baslatmak icin bir tusa basiniz";
            Time.timeScale = 0;

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f,0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);
        }

       
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgele = Random.Range(-6f, 6f);
        if (temas.gameObject.tag == "Kalp")
        {
            kalp.position = new Vector2(rastgele,6f);
            puan += 5;
        }
        if (temas.gameObject.tag == "sopa")
        {
                sopa.position = new Vector2(rastgele, 6f);
                can--;
        }

    }
}
