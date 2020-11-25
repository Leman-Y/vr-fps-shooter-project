using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<VRLookWalk>())
        {
            Debug.Log("working");
            other.GetComponent<Timer>().setFinnishTo();
        }
    }
}
