﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffRain : MonoBehaviour
{
    public GameObject rain;

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
        rain.SetActive(false);
    }
}
