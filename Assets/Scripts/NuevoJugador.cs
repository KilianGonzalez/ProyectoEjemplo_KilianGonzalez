using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoJugador : MonoBehaviour
{
    private float _vel;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 8;
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
        transform.position = newpos;
    }
}
