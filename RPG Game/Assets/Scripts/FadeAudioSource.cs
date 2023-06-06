using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class FadeAudioSource
 

{

    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return new WaitForSeconds(0.1f);
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume < 1)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return new WaitForSeconds(0.1f);
        }

        audioSource.Play();
        audioSource.volume = startVolume;
    }


}