using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeDisabler : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        
            Cursor.visible = false;
        
    }

    

    

    void Update()
    {
        
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            //Cursor.visible = false;
            Application.Quit();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Escape key was released");
            //Cursor.visible = false;
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Escape key is being pressed");
            //Cursor.visible = false;
            Application.Quit();
        }
    }
}
