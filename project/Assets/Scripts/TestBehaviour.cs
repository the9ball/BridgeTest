using BridgeTest;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    private Task _a;

    void Start()
    {
        Class1.Log = x => Debug.Log(x);
        _a = Class1.RunA();
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while (!_a.IsCompleted) yield return null;

        var tb = Class1.RunB();
        while (!tb.IsCompleted) yield return null;
        Debug.Log("Result:" + tb.Result);

        Debug.Log("Finish");
    }
}

