using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Timer : MonoBehaviour
{

    int SegundosTotales = 10;
    private int SegundosTranscurridos;
    private float Contador = 0;
    public GameObject perdiste;

    public Text contadorSeg;
    // Start is called before the first frame update
    void Start()
    {
        perdiste.SetActive(false);
        Contador = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Contador + 1)
        {
            Contador++;
            SegundosTranscurridos++;
            SegundosTotales--;
        }

        contadorSeg.text = Convert.ToString(SegundosTotales);

        if (SegundosTotales == 0)
        {
            perdiste.SetActive(true);
        }

    }

}
