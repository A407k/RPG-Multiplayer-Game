using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Start()
    {
        
    }
    IEnumerator run()
    {

        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hello");
        
    }
}
