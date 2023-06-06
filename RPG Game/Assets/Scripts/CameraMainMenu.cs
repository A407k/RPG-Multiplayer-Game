using Lean.Gui;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraMainMenu : MonoBehaviour
{
    public float Speed = 500f;
    public float factor = 1500f;
    [SerializeField] Transform tp;
    [SerializeField] Transform st;
    [SerializeField] GameObject text;
    [SerializeField] GameObject lb;
    [SerializeField] AudioClip clip;
    [SerializeField] GameObject eb;
    [SerializeField] GameObject Aug;
    [SerializeField] GameObject Multi;
    int i = 0;
    [SerializeField] String[] texts;
    [SerializeField] Text stor;
    Boolean Crr = false;
    Boolean c = false;
    bool r = false;

    // Update is called once per frame
    void Update()
    {
        if (!Crr)
        {
            Crr = true;
            stor.text = texts[0];
            stor.color = new Color(stor.color.r, stor.color.g, stor.color.b, 0);
            StartCoroutine(FadeInOut(5f, stor, 0, texts));
        }
        if (c)
        {
            text.SetActive(true);
            c = false;
        }
        gameObject.transform.Translate(Vector3.forward*Speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Return) && !r)
        {
            r = true;
            StopCoroutine(FadeInOut(5f, stor, 0, texts));
            stor.gameObject.SetActive(false);
            GetComponentInChildren<AudioSource>().clip = clip;
            GetComponentInChildren<AudioSource>().Play();
            text.SetActive(false);
            gameObject.transform.SetPositionAndRotation(tp.position, tp.rotation);
            Speed = 3000f;
        }
        if (st.position.x<=gameObject.transform.position.x)
        {
            lb.SetActive(true);
            Aug.SetActive(true);
            eb.SetActive(true);
            Multi.SetActive(true);
            Speed = 0;
        }
    }
    public void transit()
    {
        SceneManager.LoadScene(2);
    }
    public void transittoMulti()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator FadeInOut(float t,Text i,int s, String[] texts)
    {
        
        while (s < texts.Length)
        {
            StartCoroutine(FadeTextToFullAlpha(t, i));
            yield return new WaitForSeconds(4);
            StartCoroutine(FadeTextToZeroAlpha(t, i));
            yield return new WaitForSeconds(4);

            s++;
                if (s > texts.Length - 1)
                {
                    continue;
                }
            i.text = texts[s];
               
        }
        c = true;
    }
    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime * t));
            yield return new WaitForSeconds(0.1f);
        }
        
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime * t));
            yield return new WaitForSeconds(0.1f);
        }
        
    }
}
