using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ImageComponent : MonoBehaviour, IPointerClickHandler
{
    public string NewScene;
    public Animator transition;

    public void OnPointerClick(PointerEventData eventData) => StartCoroutine(LoadLevel());
    
    IEnumerator LoadLevel()
    {
        Debug.Log("Called");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(NewScene);
    }
}
