using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	[SerializeField] public float Distance;

	
	public GameObject Player;
	public GameObject Background;
	 bool isDialogueActive;

	public Dialogue dialogue;



    public void Start()
    {
		isDialogueActive = false;
    }

    public void Update()
    {
		float X_distance = System.Math.Abs(Player.transform.position.x - gameObject.transform.position.x);
		float Z_distance = System.Math.Abs(Player.transform.position.z - gameObject.transform.position.z);

		if(X_distance<Distance && Z_distance<Distance)
        {
			if (Input.GetKeyDown(KeyCode.E))
			{
				if (isDialogueActive == false)
				{
					isDialogueActive = true;
					TriggerDialogue();
				}
			}
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }

        }

		if(X_distance>Distance || Z_distance>Distance)
        {
			isDialogueActive = false;

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