using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Panda;
using Unity.VisualScripting;

public class GuardAI : MonoBehaviour
{
    GameObject[] waypoints;
    Transform t;
    
    private void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
         t = waypoints[Random.Range(0, waypoints.Length - 1)].transform;
        gameObject.GetComponent<NavMeshAgent>().SetDestination(t.transform.position);

    }
    private void Update()
    {
        if (Vector3.Distance(t.position, gameObject.transform.position) <= 1f)
        {
            t = waypoints[Random.Range(0, waypoints.Length - 1)].transform;
            gameObject.GetComponent<NavMeshAgent>().SetDestination(t.transform.position);
        }
    }



}
