using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{


    public GameObject InventoryCanvas;
    private int lastPressed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     //Update is called once per frame
    void Update()
   {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (lastPressed != 1)
            {
                InventoryCanvas.SetActive(true);
                lastPressed = 1;
                Time.timeScale = 0;
                //Cursor.visible = false;
                //Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                InventoryCanvas.SetActive(false);
                lastPressed = 0;
                Time.timeScale = 1;
                //Cursor.visible = false;

            }



        }
    }
}
