using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnMng : MonoBehaviour
{
    public GameObject VenderInside, Manual, BtnOff;
    public List<GameObject> expBtnList;
    public AudioSource sound;
    public AudioClip open, close, drop, cam, btn;
    

    public void GoToInside()
    {
        sound.clip = drop;
        sound.Play(); 
        VenderInside.SetActive(true);
    }
    public void GoToOutside()
    {
        sound.clip = close;
        sound.Play();
        VenderInside.SetActive(false);
    }

    public void ManualOn()
    {
        Manual.SetActive(true);
        ExpBtnAllOff();
    }

    public void ManualOff()
    {
        Manual.SetActive(false);
        ExpBtnAllOn();
    }

    public void ExpBtnAllOn()
    {
        foreach(GameObject a in expBtnList)
        {
            a.SetActive(true);
        }
    }

    public void ExpBtnAllOff()
    {
        foreach(GameObject a in expBtnList)
        {
            a.SetActive(false);
        }
    }

    public void BtnOffOn()
    {
        BtnOff.SetActive(true);
    }

    public void BtnOffOff()
    {
        BtnOff.SetActive(false);
    }
    
    
}
