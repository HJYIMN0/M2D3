using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio11_script : MonoBehaviour
{

    public float voto = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (voto > 10f)
        {
            Debug.Log("Voto non valido");
        }
        else if (voto == 10f)
        {
            Debug.Log("Voto A+");
        }
        else if (voto >= 7.8f)
        {
            Debug.Log("Voto A");
        }
        else if (voto >= 6f)
        {
            Debug.Log("Voto B");
        }
        else if (voto >= 5f)
        {
            Debug.Log("Voto C");
        }
        else if (voto < 5f)
        {
            Debug.Log("Voto F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
