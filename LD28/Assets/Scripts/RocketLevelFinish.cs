﻿using UnityEngine;
using System.Collections;

public class RocketLevelFinish : MonoBehaviour {

    public GameObject rocket;
    public bool finished = false;
	
	// Update is called once per frame

    public void Finish()
    {
        finished = true;
        CameraFade.StartAlphaFade(Color.black, false, 4f, 0f, () => { Application.LoadLevel("room"); });
        Debug.Log("Game finished!");
    }

	void Update () {
        if (rocket.transform.position.y > transform.position.y && !finished)
        {
            Finish();
        }
	}
}
