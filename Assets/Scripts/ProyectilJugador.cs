using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilJugador : MonoBehaviour
{
    private float _vel;
    private Vector2 maxPantalla;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 10f;
        maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posactual = transform.position;
        posactual = posactual + new Vector2(0, 1) * _vel * Time.deltaTime;
        transform.position = posactual;

        if (transform.position.y > maxPantalla.y)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D objetotocado)
    {
        if (objetotocado.tag == "Numero")
        {
            Destroy(gameObject);
        }
    }
}
