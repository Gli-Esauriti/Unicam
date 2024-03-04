using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartTriggerComponent : MonoBehaviour
{
    public Dialogue dialogue;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Test()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
