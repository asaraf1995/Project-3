using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wand_collision : MonoBehaviour
{
    public GameObject box;
    public GameObject trophy;
    
    public void OnCollisionEnter(Collision collision)
    {

            box.SetActive(false);
            trophy.SetActive(true);
  
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
