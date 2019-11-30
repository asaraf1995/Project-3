using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeTouching : MonoBehaviour
{
    //public static bool RedCube;
    // Start is called before the first frame update
    void Start()
    {
        //RedCube = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("red"))
        {
            CubesTouching.RedCube = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("red"))
        {
            CubesTouching.RedCube = false;
        }
    }

}
