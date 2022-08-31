using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCross : MonoBehaviour
{
    private int lastPressed = 0;
    public GameObject Cross;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (lastPressed != 1)
            {
                Cross.SetActive(true);
                lastPressed = 1;
                
            }
            else
            {
                Cross.SetActive(false);
                lastPressed = 0;
                
                

            }
        }
    }
}
