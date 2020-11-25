using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPa : MonoBehaviour
{
    public Transform player;
    private float dist;
    public float moveSpeed;
    public float howClose;
    // Start is called before the first frame update
    public float health;

    public AudioSource zombieSounds;

    private CoinScript coinScript;
 
    void Awake()
    {
        GameObject coinObject = GameObject.Find ("Coin");
        coinScript = coinObject.GetComponent<CoinScript>();
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
        dist = Vector3.Distance(player.position, transform.position);
        if(dist <= howClose)
        {
            transform.LookAt(player);
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
            if (zombieSounds.isPlaying == false){
                zombieSounds.Play();    
            }
        } else {
            if (zombieSounds.isPlaying == true){
                zombieSounds.Stop();
            }
        }
    }


    public void TakeDamage(int damage){
        health -= damage;
        Debug.Log("Damage Taken");
        if (health <= 0){
            Destroy(gameObject);
            coinScript.gh.points++;
        }
    }

    void OnCollisionEnter (Collision collisionInfo){
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "PlayerBullets"){
            TakeDamage(50);
        }
    }

}
