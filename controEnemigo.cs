﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//control para los enemigos
public class controEnemigo : MonoBehaviour {

    public float MaxVel = 1f;
    public float velocidad=1f;

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb2d.AddForce(Vector2.right * velocidad);
        float limiteVel = Mathf.Clamp(rb2d.velocity.x, -MaxVel, MaxVel);
        rb2d.velocity = new Vector2(limiteVel, rb2d.velocity.y);

        if(rb2d.velocity.x>-0.01f && rb2d.velocity.x < 0.01f)
        {
            velocidad = -velocidad;
            rb2d.velocity = new Vector2(velocidad, rb2d.velocity.y);
        }
        if (velocidad > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (velocidad < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

    }
}
