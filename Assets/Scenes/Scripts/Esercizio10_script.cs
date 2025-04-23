using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio10_script : MonoBehaviour
{

    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time +=Time.deltaTime;
        Debug.Log(time);
        if (time < 30)
        {
            Debug.LogWarning("Sono trascorsi meno di 30 secondi");
        }
        else if (time > 60)
        {
            Debug.LogWarning("È trascorso più di un minuto");
        }
        else if (time > 45)
        {
            Debug.LogWarning("Sono trascorsi almeno 45 secondi");
        }
        else if (time > 30)
        {
            Debug.LogWarning("Sono trascorsi più di 30 secondi");
        }
        
    }
}
