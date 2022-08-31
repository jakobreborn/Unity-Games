using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPerspective : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 0.2f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -0.2f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.1f, 0);
        }



    }
}
