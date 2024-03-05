using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static HashSet<Dialogue> Dialogues = new();
    private Queue<string> sentences;
    private Dialogue currentDialogue;
    public Text dialogueText;
    public Text nameText;

    void Start()
    {
        sentences = new Queue<string>();
        DontDestroyOnLoad(this);
    }
    
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log($"Starting conversation with {dialogue.name}");
        currentDialogue = dialogue;
        sentences.Clear();
        dialogueText.text = string.Empty;
        nameText.text = "NPC";

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }
    
    private IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = string.Empty;
        foreach (char letter in sentence)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }
    
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence));
    }
    
    void EndDialogue()
    {
        Debug.Log("End of conversation");
        currentDialogue.transition.SetTrigger("End");
        currentDialogue = null;
    }
}
