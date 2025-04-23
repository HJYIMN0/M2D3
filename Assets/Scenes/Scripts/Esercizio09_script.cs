using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio09_script : MonoBehaviour
{

    public int a = 5;
    public int b = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sarà stampato solo il valore minore");
        if (a - b > 0)
        {
            Debug.Log("Il numero minore è b " + b);
        }
        if (b - a > 0)
        {
            Debug.Log("Il numero minore è a " + a);        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
