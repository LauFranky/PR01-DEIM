using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private string myVar = "Hola jugador";
    private int myInt = 123;
    private float myFloat = 2.5f;
    private bool myBool = true;
    
    

    // Start is called before the first frame update
    void Start()
    {
        print(myVar + myInt + myFloat + myBool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
