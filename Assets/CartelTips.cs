using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartelTips : MonoBehaviour
{
    public GameObject mCartel;
    public GameObject ctext;

    public void makeVisable()
    {
        mCartel.SetActive(true);
        ctext.SetActive(true);
    }
    public void makeNotVisable()
    {
        mCartel.SetActive(false);
        ctext.SetActive(false);
    }
    public void ChangeText()
    {
        if (ctext.GetComponent<TextMesh>().text.Length == 0) {

            ctext.GetComponent<TextMesh>().text = "<----";
        }
        else if ((ctext.GetComponent<TextMesh>().text == "<----"))
        {
            ctext.GetComponent<TextMesh>().text = "---->";
        }
        else if ((ctext.GetComponent<TextMesh>().text == "---->"))
        {
            ctext.GetComponent<TextMesh>().text = "<----";
        }
    }


}
