using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public gameHandler gh;
    public AudioClip pointsSound;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerShoot>() || other.gameObject.tag == "PlayerBullets")
        {


            AudioSource.PlayClipAtPoint(pointsSound, transform.position);
            Destroy(gameObject);
            gameObject.SetActive(false);
            
            gh.points++;

        }
    }
    public void soundsg()
    {
        AudioSource.PlayClipAtPoint(pointsSound, transform.position);
    }
}
