using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountDownController : MonoBehaviour
{
    public int time = 5;
    public Text countDownText;
    [SerializeField] public RaceController rC; 

    private void Start()
    {
        countDownText = GetComponent<Text>();
        rC.raceStarted = true; 
        while(time > 0)
        {
            StartCoroutine(StartTimer());
            break;
        }
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(1.0f);
        time--;
        yield return new WaitForSeconds(1.0f);
        time--;
        yield return new WaitForSeconds(1.0f);
        time--;
        yield return new WaitForSeconds(1.0f);
        time--;
        yield return new WaitForSeconds(1.0f);
        time--;
    }

    private void Update()
    {
        countDownText.text = time.ToString();
        if(rC.raceStarted == true)
        {
            if(time <= 0)
            {
                countDownText.text = "Go!";
            }
        }
    }
}
