using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform playerPosistion;
    

    


    public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Teleporting());
        //GameObject.FindWithTag("Player").GetComponent<FirstPersonAIO>().enabled = false;
        
        //GameObject.FindWithTag("Player").transform.position = playerPosistion.position;
        
        //GameObject.FindWithTag("Player").transform.rotation = playerPosistion.rotation;
        

        //GameObject.FindWithTag("Player").transform.localPosition = playerPosistion.localPosition;
        //GameObject.FindWithTag("Player").transform.localRotation = playerPosistion.localRotation;
    }

    //public void OnCollisionExit(Collision collision)
    //{

        //GameObject.FindWithTag("Player").transform.position = playerPosistion.position;

        //GameObject.FindWithTag("Player").transform.rotation = playerPosistion.rotation;

        //GameObject.FindWithTag("Player").GetComponent<FirstPersonAIO>().enabled = true;



        //GameObject.FindWithTag("Player").transform.localPosition = playerPosistion.localPosition;
        //GameObject.FindWithTag("Player").transform.localRotation = playerPosistion.localRotation;

    //}

    IEnumerator Teleporting()
    {
        GameObject.FindWithTag("Player").GetComponent<FirstPersonAIO>().enabled = false;
        
        yield return new WaitForSeconds(0.2f);
        GameObject.FindWithTag("Player").transform.position = playerPosistion.position;

        

        GameObject.FindWithTag("Player").transform.rotation = playerPosistion.rotation;
        GameObject.FindWithTag("Player").GetComponent<FirstPersonAIO>().enabled = true;
        
        //StopAllCoroutines();

    }
}
