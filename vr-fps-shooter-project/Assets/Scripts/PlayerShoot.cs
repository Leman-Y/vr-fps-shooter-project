using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Camera playerCamera;
    public GameObject bulletPrefab;
    public GameObject gun;
    //public AudioClip gunshoot;
    public GameObject bulletHole;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            
         GameObject bulletObject = Instantiate(bulletPrefab);
           // AudioSource.PlayClipAtPoint(gunshoot, playerCamera.transform.position);
           // bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
         // bulletObject.transform.forward = playerCamera.transform.forward;
            bulletObject.transform.position = bulletHole.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = bulletHole.transform.forward;

        }
    }
}
