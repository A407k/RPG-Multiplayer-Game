using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInterval : MonoBehaviour
{
    AudioSource asc;
    bool play;
    private void Start()
    {
        asc = GetComponent<AudioSource>();
        play = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            asc.Play();
            play = false;
        }
        if (!asc.isPlaying)
        {
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(Random.Range(5, 20));
        play = true;
    }
}
