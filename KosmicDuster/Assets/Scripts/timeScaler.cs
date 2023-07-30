using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeScaler : MonoBehaviour
{
   private float originalTimeScale;

    public void SlowDown(float slowdownFactor, float duration)
    {
        originalTimeScale = Time.timeScale;
        Time.timeScale = slowdownFactor;
        StartCoroutine(RestoreTime(duration));
    }

    private IEnumerator RestoreTime(float duration)
    {
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = originalTimeScale;
    }
}