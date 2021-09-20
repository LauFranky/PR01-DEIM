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

    public int myNumber;


    // Start is called before the first frame update
    void Start()
    {
        while(myNumber != 6)
        {
            myNumber = Random.Range(0, 20);
            print("El número es " + myNumber);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
