using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio08_script : MonoBehaviour
{

    public int a = 1;
    public int b = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("verrà stampato solo il valore più alto");
        if (a - b > 0)
        {
            Debug.Log("il valore più alto è a" + a);
        }
        else
        {
            Debug.Log("Il valore più alto è b" + b);   
        }
        if (a - b == 0)
        {
            Debug.LogWarning("I numeri sono uguali");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
