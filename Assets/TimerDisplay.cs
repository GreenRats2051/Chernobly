using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    public Text timerText;
    private float timer;

    private void Start()
    {
        timer = 0f;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (true)
        {
            timer += Time.deltaTime;
            timerText.text = $"{timer:F2}";
            yield return null;
        }
    }
}
