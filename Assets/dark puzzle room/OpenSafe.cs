using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSafe : MonoBehaviour
{
    public GameObject safeClosed;
    public GameObject safeOpen;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("key"))
        {
            safeClosed.SetActive(false);
            safeOpen.SetActive(true);
        }
    }
}
