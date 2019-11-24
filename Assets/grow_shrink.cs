using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow_shrink : MonoBehaviour
{
	public GameObject alias;
	public float x_change = 9.6f;
	public float y_change = 4.0f;
	public float z_change = -35.4f;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollision(Collision other)
    {
        alias.transform.localPosition = new Vector3(x_change, y_change, z_change);

    }

}
