using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio05_script : MonoBehaviour
{

    public int a = 8;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("numero � pari o � dispari?");
        if (a % 2 == 0)
        {
            Debug.Log("Il numero � pari " + a);
        }
        else
        {
            Debug.Log("Il numero � dipari" + a);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
