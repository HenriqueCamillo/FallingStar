﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : Interactable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void effect(GameObject player){
        StageManager.instance.endStage();
    }
}
