using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wand_collision : MonoBehaviour
{
    public GameObject box;
    public GameObject trophy;
    public GameObject sound;
    public GameObject dementor;
    public GameObject dementor1;
    public GameObject dementor_effects;
    public GameObject dementor_effects1;
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
        if (collision.gameObject.name == "Dementor")
        {
//yield return new WaitForSeconds(2);
            dementor.SetActive(false);
            dementor_effects1.SetActive(true);
        }
        if (collision.gameObject.name == "Dementor 1")
        {
            dementor1.SetActive(false);
            dementor_effects.SetActive(true);
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
