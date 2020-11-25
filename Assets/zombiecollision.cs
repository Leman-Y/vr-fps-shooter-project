using UnityEngine;

public class zombiecollision : MonoBehaviour
{
	void OnCollisionEnter (Collision collisionInfo){
		Debug.Log(collisionInfo.collider.name);
		if (collisionInfo.collider.name == "Bullet(Clone)"){
			//TakeDamage(50);
		}
	}

}
