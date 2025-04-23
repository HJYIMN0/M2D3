using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int a = 1;
    public int b = 2;
    public int c = 3;
    public int d = 4;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Somma delle funzioni" + (a + b + c + d));
        Debug.Log("Prodotto delle funzioni" + (a * b * c * d));
        Debug.Log("Media delle funzioni" + ((a + b + c + d) / 4));

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
