﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public Vector3 rate;
	// public float xRate = 0f;
	// public float yRate = 0f;
	// public float zRate = 0f;

	void Update () {
		// transform.Rotate (new Vector3 (xRate, yRate, zRate) * Time.deltaTime);
		transform.Rotate (rate * Time.deltaTime);
	}
}
