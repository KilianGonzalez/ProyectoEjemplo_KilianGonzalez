using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosObtenidos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Puntos: " + DatosGlobales.puntos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
