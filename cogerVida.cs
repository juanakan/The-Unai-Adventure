using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cogerVida : MonoBehaviour {

    public AudioSource cogeCorazon;

    public void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            cogeCorazon.Play();
            GetComponent<ParticleSystem>().Play();
            Destroy(gameObject,1f);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }

    }
}
