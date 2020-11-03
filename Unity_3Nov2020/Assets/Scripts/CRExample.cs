using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRExample : MonoBehaviour
{
    private Coroutine sayHelloCR;

    // Start is called before the first frame update
    private void Start()
    {
        sayHelloCR = StartCoroutine(SayHelloCR(4.0f));
        StartCoroutine(SumUpCR(1.0f));
    }

    private IEnumerator SayHelloCR(float interval)
    {
        WaitForSeconds wait = new WaitForSeconds(interval);

        while (true)
        {
            Debug.Log("Hello");

            yield return wait;
        }
    }

    private IEnumerator SumUpCR(float interval)
    {
        int value = 0;
        WaitForSeconds wait = new WaitForSeconds(interval);

        while (true)
        {
            value += 1;

            if (value >= 30)
            {
                StopCoroutine(sayHelloCR);
                Debug.Log("Stopped saying hello.");
                yield break; // If we don't want this Coroutine to run forever
            }

            yield return wait;
        }
    }
}
