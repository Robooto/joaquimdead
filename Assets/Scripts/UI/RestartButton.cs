﻿using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
