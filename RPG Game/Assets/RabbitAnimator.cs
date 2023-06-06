using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RabbitAnimator : MonoBehaviour
{
    bool trans = false;

  void  Start()
    {
        for (; ; )
        {
            StartCoroutine("transit");
        }
    }
    IEnumerator  transit()
    {
        Debug.Log("yolo");
        gameObject.GetComponent<Animator>().SetBool("Transition", !trans);
        trans = !trans;
        yield return new WaitForSeconds(5);
    }
    
}
