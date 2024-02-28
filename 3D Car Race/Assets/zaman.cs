using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zaman : MonoBehaviour
{
    public Text zamans;
    public static float gel;

   //2 minutes

    private void Update()
    {
        gel += Time.deltaTime;
        UpdateLevelTimer(gel);
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(gel / 60f);
        int seconds = Mathf.RoundToInt(gel % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        zamans.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
