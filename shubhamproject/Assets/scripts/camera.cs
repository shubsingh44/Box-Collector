﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	[SerializeField]
	private float xMax;
	[SerializeField]
	private float yMax;
	[SerializeField]
	private float xMin;
	[SerializeField]
	private float yMin;
	private Transform target;
	void Start () {
		target = GameObject.Find ("player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Clamp (target.position.x, xMin, xMax), Mathf.Clamp (target.position.y, yMin, yMax),transform.position.z);
	}
}