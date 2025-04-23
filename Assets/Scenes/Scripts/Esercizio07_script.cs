using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio07_script : MonoBehaviour
{
    public int partenza = 6;

    // Start is called before the first frame update
    void Start()
    {
        int precedente = partenza - 1;
        int ancoraPrecedente = partenza - 2;
        Debug.Log("Il numero di partenza è " + partenza);
        Debug.Log("Il numero subito precedente è " + precedente);
        Debug.Log("Il numero ancora precedente è " + ancoraPrecedente);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
