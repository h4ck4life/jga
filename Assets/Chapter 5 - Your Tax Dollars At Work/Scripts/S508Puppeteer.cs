﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S508Puppeteer : CutscenePuppeteer {

	private bool fadeStarted = false;
		
	// Use this for initialization
	void Start () {
		startTimer ();
	}
	
	// Update is called once per frame
	public void FixedUpdate () {
		if (timerIsGreaterThan (3.5f)) {
			if(!fadeStarted) {
				StartCoroutine(FadeAndNext(Color.black, 5.0f, null));
				fadeStarted = true;
			}
		}
	}

	public override void HandleSceneChange() {

	}

}