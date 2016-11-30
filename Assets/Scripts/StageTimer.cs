﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageTimer : MonoBehaviour {
	float timeLeft = 60;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			Debug.Log ("Gameover!");
		}
			
		Text txt = gameObject.GetComponent<Text> ();
		txt.text = "Time: " + (int) timeLeft;
	}
}
