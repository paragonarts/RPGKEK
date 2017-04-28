﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public delegate void ActionListeners();
    public event ActionListeners OnPlayersAction;
	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        gameObject.GetComponent<Transform>().Translate(Input.GetAxis("Horizontal")*speed, 0, Input.GetAxis("Vertical")*speed);

        if (Input.GetButtonDown("E")) {
            OnPlayersAction();
        }
    }
}