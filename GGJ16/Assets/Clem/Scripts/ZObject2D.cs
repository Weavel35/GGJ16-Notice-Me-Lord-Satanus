﻿using UnityEngine;
using System.Collections;

public class ZObject2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.tag.Equals("Player") || coll.tag.Equals("PNJ")) {
			coll.GetComponent<SpriteRenderer>().sortingOrder = 198;
		}
	}

	void OnTriggerExit2D(Collider2D coll) {
		if(coll.tag.Equals("Player") || coll.tag.Equals("PNJ")) {
			coll.GetComponent<SpriteRenderer>().sortingOrder = 200;
		}
	}
}
