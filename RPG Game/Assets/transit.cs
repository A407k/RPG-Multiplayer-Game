using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Loading");
    }
    IEnumerator Loading()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }

    
}
