using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzleAnswer : MonoBehaviour
{
    public GameObject wheel01;
    public GameObject wheel02;
    public GameObject wheel03;
    public GameObject wheel04;
    public GameObject congrats;

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        bool correct = false;
        if (wheel01.transform.rotation.z >= 146 && wheel01.transform.rotation.z <= 161
            && wheel02.transform.rotation.z > 271 && wheel02.transform.rotation.z < 286
            && wheel03.transform.rotation.z > 21 && wheel03.transform.rotation.z < 36
            && wheel04.transform.rotation.z > 90 && wheel04.transform.rotation.z < 105)
        {
            correct = true;
        }
        congrats.SetActive(correct);
        */
        bool correct = false;
        if (wheel01.transform.eulerAngles.z >= 146.0f && wheel01.transform.eulerAngles.z <= 161.0f
            && wheel02.transform.eulerAngles.z >= 271.0f && wheel02.transform.eulerAngles.z <= 286.0f
            && wheel03.transform.eulerAngles.z >= 21.0f && wheel03.transform.eulerAngles.z <= 36.0f
            && wheel04.transform.eulerAngles.z >= 90.0f && wheel04.transform.eulerAngles.z <= 105.0f)
        {
            correct = true;
        }
        congrats.SetActive(correct);
    }
}
