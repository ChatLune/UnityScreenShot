using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	float power;
	float rand;

	void Start(){
		power = 5.0f;
		GetComponent<Rigidbody> ().AddForce (0, power, 0, ForceMode.Impulse);
		rand = Random.Range (-0.1f, 0.2f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (rand, 0, 0,Space.World);
		transform.Rotate(new Vector3(15,0,15));
		if (transform.position.y < -5.5f) {
			Destroy (gameObject);
		}
	}
}
