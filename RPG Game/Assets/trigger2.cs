using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger2 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool hasbeentreeTriggered = false;
    [SerializeField] public float Distance;
    [SerializeField] GameObject Player;
    [SerializeField] Text text;
    // Start is called before the first frame update
    
    

    // Update is called once per frame
    void Update()
    {
        float X_distance = System.Math.Abs(Player.transform.position.x - gameObject.transform.position.x);
        float Z_distance = System.Math.Abs(Player.transform.position.z - gameObject.transform.position.z);

        if (X_distance < Distance && Z_distance < Distance)
        {
             hasbeentreeTriggered = true;
                text.text = "Quest: Follow the Blood trail";
           
        }
    }
}
