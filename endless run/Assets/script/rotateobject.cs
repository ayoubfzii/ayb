using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobject : MonoBehaviour
{
    public int rotatespeed = 1;
   
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
    }
}
