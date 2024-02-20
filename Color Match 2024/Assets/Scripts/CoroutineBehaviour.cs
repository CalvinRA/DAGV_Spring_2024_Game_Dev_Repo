using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    public bool runRepeat;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        startCountEvent.Invoke();
        yield return wfsObj;

        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        runRepeat = true;
        StartCoroutine(RepeatUntilFalse());
    }
    
    private IEnumerator RepeatUntilFalse()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        
        while (runRepeat)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}