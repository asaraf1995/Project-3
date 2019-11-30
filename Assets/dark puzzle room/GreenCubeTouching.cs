using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubeTouching : MonoBehaviour
{
   // public static bool GreenCube;

    // Start is called before the first frame update
    void Start()
    {
        //GreenCube = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("green"))
        {
            CubesTouching.GreenCube = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("green"))
        {
            CubesTouching.GreenCube = false;
        }
    }
}
