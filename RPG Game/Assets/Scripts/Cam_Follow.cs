using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class Cam_Follow : MonoBehaviourPun
{







    public Transform lookAt;
    public GameObject Cam;

    public Transform Player;

    public float distance = 4.0f;
    private float currentX = 0.0f;
    public float sensivity = 200.0f;

    private void Awake()
    {
        if (photonView.IsMine)
        {
            Cam = GameObject.FindGameObjectWithTag("MainCamera");

        }



    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {




        if (photonView.IsMine)
        {
            currentX += Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;

            Vector3 Direction = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(28.0f, currentX, 0);
            Cam.transform.position = lookAt.position + rotation * Direction;

            Cam.transform.LookAt(lookAt.position);
        }

    }






}
