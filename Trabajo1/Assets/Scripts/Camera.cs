using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;


    // Update is called once per frame
    void Update()
    {
        MoverCamara();
    }

    void MoverCamara()
    {
        transform.LookAt(player);

        print(playerObject.transform.position);
        float newX = playerObject.transform.position.x;
        float newY = playerObject.transform.position.y;
        float newZ = transform.position.z;

        transform.position = new Vector3(newX, newY, newZ);
    }
}
