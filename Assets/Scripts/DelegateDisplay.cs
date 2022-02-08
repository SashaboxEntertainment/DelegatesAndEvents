using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDisplay : MonoBehaviour
{
    public delegate void TestDelegate(int a);

    private void Start()
    {
        TestDelegate testDelegate = null;

        testDelegate += Delegates;
        testDelegate += AreCool;

        testDelegate?.Invoke(5);
    }

    public void Delegates(int a)
    {
        Debug.Log("Delegates");
    }

    public void AreCool(int a)
    {
        Debug.Log("are cool");
    }
}