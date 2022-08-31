using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEnable : MonoBehaviour
{
    public GameObject thisClue;
    public GameObject clueFound;

    

    public void OnCollisionEnter(Collision collision)
    {
        thisClue.SetActive(true);
        clueFound.SetActive(true);
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {

        yield return new WaitForSeconds(3);
        clueFound.SetActive(false);
        StopAllCoroutines();

        
        Destroy(this);
    }

    
}
