using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour {

    public GameObject bullet;
    float time;
	float seed;

    // Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= 0.3f) {
			Instantiate (bullet,transform.position,transform.rotation);	
			time = 0;
		}
		seed += Time.deltaTime;
		transform.position = new Vector3 (Mathf.Sin (seed)*5.5f, transform.position.y, transform.position.z);
	}
}
