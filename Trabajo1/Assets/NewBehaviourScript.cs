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
      while (Edad <= 20)
        {
            print(Edad);
            Edad++;
        }
      for (myInt = 123; myInt <= 140;)
        {
            print(myInt);
            myInt++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
