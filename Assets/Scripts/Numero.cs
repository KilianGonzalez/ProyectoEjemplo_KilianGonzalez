using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numero : MonoBehaviour
{
    private float _vel;

    public Sprite[] spritesnumeros = new Sprite[10];

    public int valornum;

    private Vector2 minPantalla;
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2f;

        System.Random rand = new System.Random();
        valornum = rand.Next(0, 10);
        GetComponent<SpriteRenderer>().sprite = spritesnumeros[valornum];

        minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
    }

    private void OnTriggerEnter2D(Collider2D objetotocado)
    {
        if(objetotocado.tag == "ProyectilJugador" || objetotocado.tag == "NaveJugador")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 nuevaPos = transform.position;
        nuevaPos = nuevaPos + new Vector2(0, -1) * _vel * Time.deltaTime;
        transform.position = nuevaPos;

        if (transform.position.y < minPantalla.y)
        {
            Destroy(gameObject);
        }
    }
}
