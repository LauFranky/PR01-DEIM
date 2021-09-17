using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public string myVar = "Hola jugador";
    public int myInt = 123;
    public float myFloat = 2.5f;
    public bool myBool = true;
    
    

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
