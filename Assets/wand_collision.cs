using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wand_collision : MonoBehaviour
{
    public GameObject box;
    public GameObject trophy;
    public GameObject sound;
    public GameObject hint;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="box")
        {
            box.SetActive(false);
            trophy.SetActive(true);
            hint.SetActive(true);
        }
        if (collision.gameObject.name == "distraction small 2")
        {
            sound.SetActive(true);
        }
        if (collision.gameObject.name == "distraction small")
        {
            sound.SetActive(true);
        }
        if (collision.gameObject.name == "distraction box")
        {
            sound.SetActive(true);
        }
        if (collision.gameObject.name == "distraction box 2")
        {
            sound.SetActive(true);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
