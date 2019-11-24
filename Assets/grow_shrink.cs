using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow_shrink : MonoBehaviour
{
	public GameObject alias;
	//public float x = 0.1f;
	//public float y = 0.1f;
	//public float z = 0.1f;
	public float x_change = 0.1f;
	public float y_change = 0.1f;
	public float z_change = 0.1f;

public void growShrink()
{
    //alias.transform.localScale = new Vector3(x, y, z);
    alias.transform.localPosition = new Vector3(x_change, y_change, z_change);

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
