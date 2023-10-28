using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    public bool start;
    public float ster;
    public GameObject Sterzh1;
    public GameObject Sterzh2;
    public GameObject Sterzh3;
    public GameObject Sterzh4;

    public GameObject nag1;
    public GameObject nag2;
    public GameObject nag3;
    public GameObject nag4;
    public int r;
    public int b;

    public GameObject Dvig;
    public GameObject Val;
    // Start is called before the first frame update
    void Start()
    {
        ster = (float)-1.5;
        start = false;
        r = 0;
        b = 255;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ster >= -2.5 && start == true) ster = (float)(ster - 0.002);
        if (ster <=-1.5 && start == false) ster = (float)(ster + 0.002);
        if (ster <= -2.5 && r<=254 && b>=1)
        {
            r++;
                b--;
        }
        if (ster >= -2 && b <= 254 && r >= 1)
        {
            r--;
            b++;
        }
        Vector3 test = transform.localPosition;
        test.z = ster;
        Sterzh1.transform.localPosition = new Vector3(Sterzh1.transform.localPosition.x, Sterzh1.transform.localPosition.y, ster);
        Sterzh2.transform.localPosition = new Vector3(Sterzh2.transform.localPosition.x, Sterzh2.transform.localPosition.y, ster);
        Sterzh3.transform.localPosition = new Vector3(Sterzh3.transform.localPosition.x, Sterzh3.transform.localPosition.y, ster);
        Sterzh4.transform.localPosition = new Vector3(Sterzh4.transform.localPosition.x, Sterzh4.transform.localPosition.y, ster);
        nag1.GetComponent<Renderer>().material.color = new Color32((byte)r, 0, (byte)b, 1);
        nag2.GetComponent<Renderer>().material.color = new Color32((byte)r, 0, (byte)b, 1);
        nag3.GetComponent<Renderer>().material.color = new Color32((byte)r, 0, (byte)b, 1);
        nag4.GetComponent<Renderer>().material.color = new Color32((byte)r, 0, (byte)b, 1);
        Dvig.transform.Rotate(Vector3.up, (float)(r * 0.1));
        Val.transform.Rotate(Vector3.up, (float)(r * 0.1));
    }
    public void working()
    {
        start = true;
    }
    public void stop()
    {
        start = false;
    }
}
