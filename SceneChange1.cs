using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)

    {
        SceneManager.LoadScene("Good Outro");



    }
}
