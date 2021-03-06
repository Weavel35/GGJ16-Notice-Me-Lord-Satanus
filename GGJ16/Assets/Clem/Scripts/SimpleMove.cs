﻿using UnityEngine;
using System.Collections;

public class SimpleMove : MonoBehaviour {

	private Animator anim;
	public Vector3 startPosition;
	public Vector2 speed = new Vector2(1,0);
	private Rigidbody2D rigibody;

	public string horizontal;
	public string vertical;

	void Start() {

		startPosition=transform.position;
		anim=GetComponent<Animator>();
		rigibody = this.GetComponent<Rigidbody2D>();
	}

	void Update() {


		float inputX = Input.GetAxis(horizontal);
		float inputY = Input.GetAxis(vertical);

		//anim.SetFloat("SpeedX", inputX);
		//anim.SetFloat("SpeedY", inputY);

		Vector3 movement = new Vector3
		(speed.x*inputX, speed.y*inputY, 0);
		this.rigibody.velocity =movement;
    
		//movement*=Time.deltaTime;
		//transform.Translate(movement);
	}

	void FixedUpdate() {
		float lastinputX = Input.GetAxis(horizontal);
		float lastinputY = Input.GetAxis(vertical);

		/*if(lastinputX!=0||lastinputY!=0) {
			anim.SetBool("walking", true);


			if(lastinputX>0) {
				anim.SetFloat("LastMoveX", 1f);
			} else if(lastinputX<0) {
				anim.SetFloat("LastMoveX", -1f);
			} else {
				anim.SetFloat("LastMoveX", 0f);
			}


			if(lastinputY>0) {
				anim.SetFloat("LastMoveY", 1f);
			} else if(lastinputY<0) {
				anim.SetFloat("LastMoveY", -1f);

			} else {
				anim.SetFloat("LastMoveY", 0f);
			}

		} else {
			anim.SetBool("walking", false);
		}*/
	}
}