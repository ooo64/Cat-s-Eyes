using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{


    public GameObject character;

    public float offsetX = 5.5f;
    public float offsetY = 0f;
    public float offsetZ = -10f;

    
    void Update()
    {
        transform.position = new Vector3(
           character.transform.position.x + offsetX,
           character.transform.position.y + offsetY,
           offsetZ
       );
    }
}
