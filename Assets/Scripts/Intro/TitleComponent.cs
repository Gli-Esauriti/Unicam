using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class TitleComponent : MonoBehaviour
{
    private void Awake()
    {
        Coroutine coroutine = StartCoroutine(Check());
    }

    IEnumerator Check()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("ciao");
        }
    }
}
