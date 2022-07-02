using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float timeInSeconds;

    public UnityEvent onTimesUp;

    IEnumerator Start() 
    {
        yield return new WaitForSecondsRealtime(timeInSeconds);
        onTimesUp?.Invoke();
    }
}
