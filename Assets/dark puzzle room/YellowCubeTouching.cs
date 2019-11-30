using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCubeTouching : MonoBehaviour
{
    //public static bool YellowCube;
    // Start is called before the first frame update
    void Start()
    {
        //YellowCube = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("yellow"))
        {
            CubesTouching.YellowCube = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("yellow"))
        {
            CubesTouching.YellowCube = false;
        }
    }
}
