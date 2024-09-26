using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoJugador : MonoBehaviour
{
    private float _vel;

    private Vector2 minPantalla, maxPantalla;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 8;

        minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

        float medidaMediaImagenX = GetComponent<SpriteRenderer>().sprite.bounds.size.x * transform.localScale.x / 2;
        float medidaMediaImagenY = GetComponent<SpriteRenderer>().sprite.bounds.size.y * transform.localScale.y / 2;
        //minPantalla.x = minPantalla.x + 0.65f;
        //minPantalla.x += 0.65f; // Es sinonimo de la linea de arriba
        minPantalla.x += medidaMediaImagenX;//Bounds
        maxPantalla.x -= medidaMediaImagenX;

        minPantalla.y += medidaMediaImagenY;
        maxPantalla.y -= medidaMediaImagenY;
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");
        //Debug.Log("X: " + dirX + " - Y: " + dirY);

        Vector2 dir = new Vector2(dirX, dirY);

        Vector2 newpos = transform.position;
        newpos = newpos + dir * _vel * Time.deltaTime;

        newpos.x = Mathf.Clamp(newpos.x, minPantalla.x, maxPantalla.x);
        newpos.y = Mathf.Clamp(newpos.y, minPantalla.y, maxPantalla.y);

        transform.position = newpos;
    }
}
