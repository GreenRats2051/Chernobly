using System.Collections;
using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    public TMP_Text timerText;
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
