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

    public int Edad = 1;



    // Start is called before the first frame update
    void Start()
    {
        for(Edad = 1; Edad <20; Edad++)
        {
            if (Edad <= 11)
            {
                print("Soy un niño felis :D");
            }
            else if (Edad > 12 && Edad <= 18)
            {
                print("Tengo la edad del pavo");
            }
            else
            {
                print("Vaya por dios, soy adulto :(");
            }
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
