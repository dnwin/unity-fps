using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
	public float speed = 0.3f;

	void Update () {
		transform.Rotate (0, speed, 0);	
	}
}
