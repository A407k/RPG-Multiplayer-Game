using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform tree;
    // Start is called before the first frame update
    [SerializeField] Camera cam;
    [SerializeField] GameObject img;

    // Update is called once per frame
    void Update()
    {
        if (trigger.hasbeenTriggered)
        {
            cam.GetComponent<WaypointMarker>().target = tree;
            trigger.hasbeenTriggered = false;
        }
        if (trigger2.hasbeentreeTriggered)
        {
            img.SetActive(false);
        }
    }
}
