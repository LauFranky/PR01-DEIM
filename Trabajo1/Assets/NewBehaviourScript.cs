using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public string myVar = "Hola jugador";
    public string myVar2 = "Estas preparado para la aventura?";

    public int myInt = 123;
    public float myFloat = 2.5f;
    public bool myBool = true;

    public int Edad = 12;
    
    

    // Start is called before the first frame update
    void Start()
    {
        print(myVar + myInt + myFloat + myBool);
        print(myInt + myFloat);
        print(myVar + myVar2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Edad <= 20)
        {
            print(Edad);
            Edad++;
        }
        
    }
}
