using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{ 
    [SerializeField] List<AudioClip> forest;
    [SerializeField] List<AudioClip> village;
    [SerializeField] List<AudioClip> Pilgrimage;
    [SerializeField] List<AudioClip> Combat;
    [SerializeField] float factor = 0.1f;
    [SerializeField] GameObject music;
    [SerializeField] GameObject Nature;
    Enumerations.MusicCategory category = Enumerations.MusicCategory.village;
    // Update is called once per frame
   void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("ForestEnter"))
        {
            if (category == Enumerations.MusicCategory.village)
            {
                category = Enumerations.MusicCategory.forest;
                music.GetComponent<AudioSource>().clip = forest[Random.Range(0, forest.Count - 1)];
                gameObject.GetComponentInChildren<AudioSource>().Play();
            }
            if (category == Enumerations.MusicCategory.mountain)
            {
                category = Enumerations.MusicCategory.forest;
                music.GetComponent<AudioSource>().clip = forest[Random.Range(0, forest.Count - 1)];
                gameObject.GetComponentInChildren<AudioSource>().Play();
            }

        }
        if (other.gameObject.CompareTag("Mountain"))
        {
            if (category == Enumerations.MusicCategory.forest)
            {
                category = Enumerations.MusicCategory.mountain;
                music.GetComponent<AudioSource>().clip = Pilgrimage[Random.Range(0, Pilgrimage.Count - 1)];
                gameObject.GetComponentInChildren<AudioSource>().Play();
            }
        }
        if (other.gameObject.CompareTag("VillageEnter"))
        {
            if (category == Enumerations.MusicCategory.forest)
            {
                category = Enumerations.MusicCategory.village;
                music.GetComponent<AudioSource>().clip = village[Random.Range(0, village.Count - 1)];
                gameObject.GetComponentInChildren<AudioSource>().Play();
            }
        }

    }
    private void Update()
    {
        if (!music.GetComponent<AudioSource>().isPlaying)
        {
            switch (category) { 
                case Enumerations.MusicCategory.forest:
                    music.GetComponent<AudioSource>().clip = forest[Random.Range(0, forest.Count - 1)];
                    gameObject.GetComponentInChildren<AudioSource>().Play();
                    break;
                    case Enumerations.MusicCategory.village:
                    music.GetComponent<AudioSource>().clip = village[Random.Range(0, village.Count - 1)];
                    gameObject.GetComponentInChildren<AudioSource>().Play();
                    break;
                case Enumerations.MusicCategory.mountain:
                    music.GetComponent<AudioSource>().clip = Pilgrimage[Random.Range(0, Pilgrimage.Count - 1)];
                    gameObject.GetComponentInChildren<AudioSource>().Play();
                    break;
            }
                 
        }
    }

    
}
