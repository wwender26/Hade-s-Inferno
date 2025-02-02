﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {
    private Scene scene;
	// Use this for initialization
	void Start () {
        scene = SceneManager.GetActiveScene();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(scene.name!="Fase 5")Application.LoadLevel("LevelSelect");
            else Application.LoadLevel("Castelo");
        }
    }

    // Update is called once per frame
    void Update () {
        if (scene.name == "Menu" && Input.GetKeyDown(KeyCode.Space)) Application.LoadLevel("Fase 1");
	}
}
