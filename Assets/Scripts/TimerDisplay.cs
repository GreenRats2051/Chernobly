using System.Collections;
using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    public ResourceTimerCollection resourceTimeData;
    public TMP_Text timerText;
    public int index;
    private float timer;
    private bool isDecay;

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {
        if (isDecay == false)
        {
            timer += Time.deltaTime;
            if (timer > resourceTimeData.resourceTimers[index].enrichmentTime)
            {
                isDecay = true;
                timer = resourceTimeData.resourceTimers[index].decayTime;
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
        timerText.text = $"{timer:F2}";
    }
}
