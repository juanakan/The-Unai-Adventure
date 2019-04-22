using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cogerOro : MonoBehaviour {

    public AudioSource sonidooro;


    public void OnTriggerEnter2D(Collider2D col)
    {
       

        if (col.tag == "Player")
        {
            GetComponent<ParticleSystem>().Play();
            sonidooro.Play();
            Destroy(gameObject, 1f);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
           
        }

    }
}
