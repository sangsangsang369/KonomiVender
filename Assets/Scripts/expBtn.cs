using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expBtn : MonoBehaviour
{
    public GameObject exp;
    public BtnMng btnMng;

    private void Awake() 
    {
        btnMng = FindObjectOfType<BtnMng>();
    }

    public void ExpOn()
    {
        btnMng.sound.clip = btnMng.btn;
        btnMng.sound.Play();
        exp.SetActive(true);
        btnMng.ExpBtnAllOff();
    }
    public void ExpOff()
    {
        exp.SetActive(false);
        btnMng.ExpBtnAllOn();
    }
}
