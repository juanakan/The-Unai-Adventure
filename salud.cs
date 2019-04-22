using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class salud : MonoBehaviour {
    public float maxsalud= 100f;
    public float dañoenemigo = 10f;
    public float masVida = 10f;
    public float saludactual;
    public Image barravida;
    public int puntos;
    public Text puntosTexto;

  


	// Use this for initialization
	void Start () {

        saludactual = maxsalud;
        barravida.fillAmount = saludactual /maxsalud;

 

		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
        if (col.CompareTag("Enemigo"))
        {
            saludactual -= dañoenemigo;
            barravida.fillAmount = saludactual / maxsalud;
           
        }
        if (col.tag == "Vida")
        {
            saludactual += masVida;
            barravida.fillAmount = saludactual / maxsalud;
        }
        if(col.tag == "oro")
        {
            puntos += 5;
            puntosTexto.text = " "+puntos.ToString();

        }
		
	}
    void Update()
    {
        if (saludactual < 0)
        {
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;
            RestartGame();
           

        }
        if (saludactual > maxsalud)
        {
            saludactual = maxsalud;
        }

            setpunt(puntos);
        if (puntos > getmax())
        {
            setmax(puntos);
        }

    }

    public void RestartGame()
    {

        SceneManager.LoadScene("game over");

    }
    public int getpunt()
    {
        return PlayerPrefs.GetInt("punt", 0);
    }
    public void setpunt(int punt)
    {
        PlayerPrefs.SetInt("punt", punt);
    }
    public int getmax()
    {
        return PlayerPrefs.GetInt("max", 0);
    }
    public void setmax(int punt)
    {
        PlayerPrefs.SetInt("max", punt);
    }


}
