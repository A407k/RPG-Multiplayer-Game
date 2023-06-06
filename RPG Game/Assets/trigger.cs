using Panda.Examples.PlayTag;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public static bool hasbeenTriggered = false;
    [SerializeField] public float Distance;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float X_distance = System.Math.Abs(Player.transform.position.x - gameObject.transform.position.x);
        float Z_distance = System.Math.Abs(Player.transform.position.z - gameObject.transform.position.z);

        if (X_distance < Distance && Z_distance < Distance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasbeenTriggered = true;
            }
        }
    }
}
