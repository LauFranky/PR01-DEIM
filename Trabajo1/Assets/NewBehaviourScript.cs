using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Saludar("Franky");
        Saludar("Yaiza");
    }
    
    // Saludito
    void Saludar(string hola)
    {
        print("Hola" + hola);
    }
}
