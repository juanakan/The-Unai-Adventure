using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//esta clase es para las plataformas que caen
public class plataformaCae : MonoBehaviour {
    public float tiempoInicio=1f;
    private Rigidbody2D rb2d;
    public float temporizador=1f;
    private Vector3 plataformaInicio;
   

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        plataformaInicio = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //metodo si el objeto con el tag player toca la plataforma
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            //si toca llamamos al metodo fall despues de el tiempo que queramos
            Invoke("Fall", temporizador);
            Invoke("Respawn", temporizador + tiempoInicio);
            
        }
    }
    //metodo que hace que el objeto rb2d que en este caso es la plataforma le quitamos kinematic y cae
    void Fall()
    {
        rb2d.isKinematic = false;
        
    }
    void Respawn()
    {
        transform.position = plataformaInicio;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector3.zero;
    }

}
