using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{

    public int SegundosTotales = 30;
    private int SegundosTranscurridos;
    private float Contador = 0;

    public Text contadorSeg;
    // Start is called before the first frame update
    void Start()
    {
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
            SceneManager.LoadScene("perder");
        }

    }

}
