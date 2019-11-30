using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeTouching : MonoBehaviour
{
    //public static bool BlueCube;
    // Start is called before the first frame update
    void Start()
    {
        //BlueCube = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("blue"))
        {
            CubesTouching.BlueCube = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("blue"))
        {
            CubesTouching.BlueCube = false;
        }
    }
}
