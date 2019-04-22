using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// esta clase me controla la vida del enemigo
public class vidaEnemigo : MonoBehaviour {

    public int vida;
    public AudioSource sonidoexplota;
    public float duracionDestroy = 1f;

    /*este metodo mira si colisiona con el tag disparo y le quita el daño que hemos puesto en la refdisparo
    Y cuando llegue a 0 se destruye el objeto enemigo*/
    public void OnTriggerEnter2D(Collider2D col) {

        if (col.tag == "Disparo")
        {
            vida -= controldisparo.daño;
            if (vida <= 0)
            {
                GetComponent<ParticleSystem>().Play();
                sonidoexplota.Play();
                Destroy(gameObject,duracionDestroy);
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;
                GetComponent<CircleCollider2D>().enabled = false;
                
            }
          
        }
        if (col.tag == "Player")
        {
            GetComponent<ParticleSystem>().Play();
            sonidoexplota.Play();
            Destroy(gameObject, duracionDestroy);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
        }

	}
}
