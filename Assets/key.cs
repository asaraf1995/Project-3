using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject mysterybox;
    public GameObject mysterybox1;
    public GameObject distmysterybox;
    public GameObject distmysterybox1;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "mystery box")
        {
            mysterybox.SetActive(false);
            mysterybox1.SetActive(true);
        }
        if (collision.gameObject.name == "distraction mystery box")
        {
            distmysterybox.SetActive(false);
            distmysterybox1.SetActive(true);
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
