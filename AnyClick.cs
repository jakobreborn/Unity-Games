using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyClick : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.anyKey)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            //Destroy(this);
        }

        
    }
}
