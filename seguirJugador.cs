using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//clase para que la camara siga al jugador
public class seguirJugador : MonoBehaviour {

    public GameObject jugador;
    private Vector3 posicion;

	// Use this for initialization
	void Start () {
        posicion = transform.position - jugador.transform.position;
		
	}
	
	// Update is called once per frame
	void Update() {
        transform.position = jugador.transform.position + posicion;
    }
		
	
}
