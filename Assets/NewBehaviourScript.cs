using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float kgusuario;
    public float km;
    string tipovehiculo;
 
    // Start is called before the first frame update
    void Start()
    {
        if (kgusuario<100 && km < 1)
        {
            Debug.Log("error");
        }
        float cuentatipovehiculo = kgusuario * km;
        if (cuentatipovehiculo <= 2000)
        {
            tipovehiculo = ("Utilitario");
        }
        if (cuentatipovehiculo<5000 && cuentatipovehiculo > 2000)
        {
            tipovehiculo = ("Pickup");
        }
        if (cuentatipovehiculo<10000 && cuentatipovehiculo > 5000)
        {
            tipovehiculo = ("Camion");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
