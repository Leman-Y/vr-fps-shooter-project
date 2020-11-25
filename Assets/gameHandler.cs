using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    public TextMesh pointsText;
    public int points = 0;
    


    // Update is called once per frame
    void Update()
    {
        pointsText.text = "POINTS : " + points;
    }
}
