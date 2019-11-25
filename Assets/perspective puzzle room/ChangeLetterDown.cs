using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLetterDown : MonoBehaviour
{
    public GameObject wheel;
    private float degreeChange = -(360.0f / 26.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        wheel.transform.Rotate(0, 0, degreeChange, Space.Self);
    }
}
