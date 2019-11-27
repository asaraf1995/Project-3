using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject mysterybox;
    public GameObject distmysterybox;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "mystery box")
        {
            mysterybox.SetActive(true);
        }
        if (collision.gameObject.name == "distraction mystery box")
        {
            distmysterybox.SetActive(true);
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
