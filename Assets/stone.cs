using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject sound;
    public GameObject alias;
    public static int count;
    public float x_change = 0.1f;
    public float y_change = 0.1f;
    public float z_change = 0.1f;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Platform 1")
        {
            count = count + 1;
            sound.SetActive(true);

        }
        else if (collision.gameObject.name == "Platform 2")
        {
            count = count + 1;
            sound.SetActive(true);
        }
        else if (collision.gameObject.name == "Platform 3")
        {
            count = count + 1;
            sound.SetActive(true);
        }
        if (count == 3)
        {
            alias.transform.localPosition = new Vector3(x_change, y_change, z_change);
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
