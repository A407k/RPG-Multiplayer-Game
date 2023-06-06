using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class Character_Contoller : MonoBehaviourPun
{

    public PhotonView view;

    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    Animator animator;

    

    private void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();

       // view = GetComponent<PhotonView>();

        animator = GetComponent<Animator>();
                
    }

    void Update()
    {

        


        //if (view.IsMine)
        if (photonView.IsMine)
        {

            animator.SetBool("IsIdle", true);

            animator.SetBool("IsAttack", false);




            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {

                animator.SetBool("IsIdle", false);
                               
                gameObject.transform.forward = move;
            }

            // Changes the height position of the player..
            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }

            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);

            if(Input.GetMouseButtonDown(0))
            {
                animator.SetBool("IsAttack", true);
            }

        }

       
    }

}
