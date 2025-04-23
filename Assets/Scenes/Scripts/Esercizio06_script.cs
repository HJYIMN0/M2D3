using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio06_script : MonoBehaviour
{

    public int partenza = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        int successivo = partenza + 1;
        int ancoraSuccessivo = partenza + 2;
        Debug.Log("Il numero di partenza è " + partenza);
        Debug.Log("Il numero subito successivo è " + successivo); 
        Debug.Log("Il numero ancora successivo è " + ancoraSuccessivo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
