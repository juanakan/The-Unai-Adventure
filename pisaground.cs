using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisaground : MonoBehaviour {

    private jugadorcontrol jugador;

	// Use this for initialization
	void Start () {
        jugador = GetComponentInParent<jugadorcontrol>();
		
	}
	
	// cada vez que colisionamos si es ground pisamos y si es platmovil pisa y se hace hijo de la plataforma movil
	void OnCollisionStay2D (Collision2D col) {
        if (col.gameObject.tag == "Ground")
        {
            jugador.pisa = true;
        }
        if (col.gameObject.tag == "platMovil")
        {
            jugador.transform.parent = col.transform;
            jugador.pisa = true;
        }
        
        
		
	}
    //cuando no colisiona pues pisa es falso y dejamos de ser hijos de la plataforma movil
    void OnCollisionExit2D(Collision2D col){
      if (col.gameObject.tag == "Ground")
        {
            jugador.pisa = false;
        }
        if (col.gameObject.tag == "platMovil")
        {
            jugador.transform.parent = null;
            jugador.pisa = false;
        }
        
        
		
	}
}
