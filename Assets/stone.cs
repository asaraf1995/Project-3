using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject sound1;
    public GameObject sound2;
    public GameObject sound3;
    public GameObject alias;
    public static int count;
    public bool flag;
    public static int flagcount;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Platform 1")
        {
            if (flagcount == 0)
            {
                flag = true;
                flagcount += 1;

                if (flag)
                {
                    count = count + 1;
                    //sound.SetActive(false);
                    sound1.SetActive(true);
                    flagcount = 0;
                    flag = false;
                }
            }
            
        }
        else if (collision.gameObject.name == "Platform 2")
        {
            if (flagcount == 0)
            {
                flag = true;
                flagcount += 1;

                if (flag)
                {
                    count = count + 1;
                    //sound.SetActive(false);
                    sound2.SetActive(true);
                    flagcount = 0;
                    flag = false;
                }
            }
        }
        else if (collision.gameObject.name == "Platform 3")
        {
            if (flagcount == 0)
            {
                flag = true;
                flagcount += 1;

                if (flag)
                {
                    count = count + 1;
                   // sound.SetActive(false);
                    sound3.SetActive(true);
                    flagcount = 0;
                    flag = false;
                }
            }
        }
        if (count == 3)
        {
            alias.transform.localPosition = new Vector3(8.0f, 2.0f, -1.0f);
        }
        //sound.SetActive(false);
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
