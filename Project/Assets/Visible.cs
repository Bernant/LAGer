using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour
{
    public bool trig;
    public bool trigr;
    public GameObject Modelst;
    public GameObject Modelvs;
    public GameObject Modelstr;
    public GameObject Modelvsr;
    private byte a;
    public void FixedUpdate()
    {
       
        if (trig == false && a <=254) a++;
        if (trig == true && a >= 128) a--;
        if (trig == false && a == 255 && trigr == false)
        {
            Modelst.SetActive(true);
            Modelvs.SetActive(false);
            Modelstr.SetActive(false);
            Modelvsr.SetActive(false);
        }
        if (trig == false && a == 255&& trigr == true)
        {
            Modelst.SetActive(false);
            Modelvs.SetActive(false);
            Modelstr.SetActive(true);
            Modelvsr.SetActive(false);
        }
        if (trig == true && trigr == false)
        {
            Modelst.SetActive(false);
            Modelvs.SetActive(true);
            Modelstr.SetActive(false);
            Modelvsr.SetActive(false);
        }
        if (trigr == true && trig ==true)
        {
            Modelst.SetActive(false);
            Modelvs.SetActive(false);
            Modelstr.SetActive(false);
            Modelvsr.SetActive(true);
        }
        Modelvs.GetComponent<MeshRenderer>().material.color = new Color32(255, 255, 255, a);
        Modelvsr.GetComponent<MeshRenderer>().material.color = new Color32(255, 255, 255, a);
    }
    public void Vischange()
    {
        if (trig == false) trig = true;
        else  trig =  false; 
    }
    public void AnimRot()
    {
        if (trigr == false) trigr = true;
        else trigr = false;
    }
}
