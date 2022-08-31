using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{


    [SerializeField] private Image uiFill;
    [SerializeField] private Text uiText;

    public int Duration;

    private int remainingDuration;

    private bool Pause;

    //private float startTime;
    //private float elapsedTime;
    

    private void Start()
    {
        Being(Duration);

        //startTime = Time.time;
    }

    
    private void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
        
    }

    private IEnumerator UpdateTimer()
    {
         
            while (remainingDuration >= 0)
        {
            if (!Pause)
            {
                uiText.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
                uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
                remainingDuration--; 
                yield return new WaitForSeconds(1f); //dwa razy wolniej leci czas - 4h w grze / 20 minut IRL / Widzi 15minut/ blinded 5 minut
            }
            yield return null;

            
          
        }

        
        
        OnEnd();
        

    }

    private void OnEnd()
    {
        //End Time , if want Do something
        //scenechange!!

        //360 powinno BYÆ!

        //elapsedTime = 0;

        Being(Duration);

        SceneManager.LoadScene("LoopGame");
        print("End");
    }
}
