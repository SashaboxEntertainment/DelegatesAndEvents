using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionQueue : MonoBehaviour
{
    Queue<Event> events = new Queue<Event>();

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(1f);
        if (events.Count > 0)
        {
            events.Dequeue();
        }
    }
}
