using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CubesTouching
{
    public static bool YellowCube;
    public static bool RedCube;
    public static bool GreenCube;
    public static bool BlueCube;
}

public class OpenVaultDoor : MonoBehaviour
{
    /*
    public static bool YellowCube;
    public static bool RedCube;
    public static bool GreenCube;
    public static bool BlueCube;  */

    public GameObject vaultItems;
    public GameObject door;

    private int i;
    // Start is called before the first frame update
    void Start()
    {
        CubesTouching.YellowCube = false;
        CubesTouching.RedCube = false;
        CubesTouching.GreenCube = false;
        CubesTouching.BlueCube = false;
        i = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (CubesTouching.RedCube && CubesTouching.YellowCube && CubesTouching.GreenCube && CubesTouching.BlueCube)
        {
            if (i == 20)
            {
                vaultItems.SetActive(true);
            }
            if (i > 0)
            {
                door.transform.Rotate(0, 5, 0);
                i--;
            }
            
            
        }
    }
}
