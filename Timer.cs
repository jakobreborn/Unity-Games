using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour 
{
    

    [SerializeField] private Image uiFill;
    [SerializeField] private Text uiText;

    public int Duration;

    private int remainingDuration;

    private bool Pause;

    private void Start()
    {
        Being(Duration);
    }

    private void Being(int Second)
    {
        
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    

    private IEnumerator UpdateTimer()
    {
        while(remainingDuration >= 0 && remainingDuration != 1380) ////zmiana z > na <
        {
            if (!Pause)
            {
                uiText.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
                uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
                remainingDuration++; //tutaj zmieniłem z -- dekrementacji w dół do inkrementacji w góre
                yield return new WaitForSeconds(2f); //2f dwa razy wolniej leci czas - 4h w grze / 20 minut IRL / Widzi 15minut/ blinded 5 minut
                Debug.Log(remainingDuration);
            }
            yield return null;
        
            
            
            
        }
        
        OnEnd();
    }

    private void OnEnd()
    {

        
        Being(Duration);
        

        //End Time , if want Do something
        //scenechange!!
        //SceneManager.LoadScene("LoopGameBlinded");
        //print("End");
    }
}
