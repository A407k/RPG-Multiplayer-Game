using Panda.Examples.PlayTag;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class start : MonoBehaviour
{ 

public GameObject Background;
bool isDialogueActive;

public Dialogue dialogue;



public void Start()
{
    isDialogueActive = false;
}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isDialogueActive == false)
        {
            isDialogueActive = true;
            TriggerDialogue();
        }

    }

    public void TriggerDialogue()
{
    if (isDialogueActive)
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}

}
