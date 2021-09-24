using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float myVar;

    // Start is called before the first frame update
    void Start()
    {
        myVar = sumar(0f, 15f);
        print(myVar);
    }

    // Calculos
    float sumar(float num1, float num2)
    {
        float resultado;
        resultado = num1 + num2;
        return resultado;
    }
}
