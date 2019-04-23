using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jugadorcontrol : MonoBehaviour
{

    public float posicionInicialX, posicionInicialY;


    public float speed = 2f;
    private Rigidbody2D rb2d;
    public float velMax = 5f;
    private Animator anim;
    public bool pisa;
    public bool dispara;
    public float fuerzasalto = 6.5f;
    private bool saltar;
    //nuevo
    public Transform punterodisparo;
    public GameObject disparoprefab;
    public AudioSource disparoSound;
    public float magia;
    public Text magiamax;
   


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("pisando", pisa);
        anim.SetBool("disparo", dispara);
        PlayerShooting();
        if (Input.GetKeyDown(KeyCode.Space)&& magia>0)
        {
            dispara = true;
            magia = magia -1;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            dispara = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && pisa)
        {
            saltar = true;
        }
        magiamax.text = " " + magia.ToString();

    }
    void FixedUpdate()
    {
        Vector3 friccion = rb2d.velocity;
        friccion.x *= 0.5f;
        if (pisa)
        {
            rb2d.velocity = friccion;
        }
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * speed * h);

        float limitevelocidad = Mathf.Clamp(rb2d.velocity.x, -velMax, velMax);

        rb2d.velocity = new Vector2(limitevelocidad, rb2d.velocity.y);

        if (h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (saltar)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * fuerzasalto, ForceMode2D.Impulse);
            saltar = false;

        }

    }

    public void PlayerShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space) && magia > 0)
        {
            Instantiate(disparoprefab, punterodisparo.position, punterodisparo.rotation);
            disparoSound.Play();

        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "magia")
        {
            magia =10;



        }

    }


}