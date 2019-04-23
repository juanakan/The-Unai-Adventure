using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cogerMagia : MonoBehaviour {

    public AudioSource sonidomagia;


    public void OnTriggerEnter2D(Collider2D col)
    {


        if (col.tag == "Player")
        {
            sonidomagia.Play();
            Destroy(gameObject, 1f);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

        }

    }
}
