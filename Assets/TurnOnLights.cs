using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLights : MonoBehaviour
{
    public GameObject[] Clight;
   private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.GetComponent<PlayerShoot>())
        {
            for (int i = 0; i < Clight.Length; i++)
            {
                Clight[i].SetActive(true);
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerShoot>())
        {
            for (int i = 0; i < Clight.Length; i++)
            {
                Clight[i].SetActive(false);
            }

        }
    }

}
