using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controldisparo : MonoBehaviour {
    public GameObject player;
    private Transform playertrans;
    private Rigidbody2D disparoRB;
    public float disparospeed;
    public float disparodestroy;
    public AudioSource sonidoexplota;
    public static int daño;
    public int refDaño;

    void Awake()
    {
        daño = refDaño;
        disparoRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playertrans = player.transform;

    }

    // Use this for initialization
    void Start() {
        if (playertrans.localScale.x > 0)
        {
            disparoRB.velocity = new Vector2(disparospeed, disparoRB.velocity.y);
        }
        else
        {
            disparoRB.velocity = new Vector2(-disparospeed, disparoRB.velocity.y);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, disparodestroy);
	}
    //comprueba el tag y si es verdadero la bala explota y se desconecta que se vea y que vuelva a tocar algo
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ground"||col.tag=="platMovil"||col.tag=="Enemigo")
        {
            GetComponent<ParticleSystem>().Play();
            sonidoexplota.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
          
        }
    }
    
}
