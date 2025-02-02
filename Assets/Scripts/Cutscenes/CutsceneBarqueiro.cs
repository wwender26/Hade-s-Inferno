﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneBarqueiro : MonoBehaviour {

    public GameObject player;
    public GameObject barqueiro;
    public bool freeze;

	// Use this for initialization
	void Start () {
        player.GetComponent<PlayerController>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (barqueiro.transform.position.x - player.transform.position.x > -0.3 && player.transform.position.x < 107)
        {
            player.GetComponent<Animator>().SetBool("isRunning", true);
            player.transform.Translate(Vector2.right * player.gameObject.GetComponent<PlayerController>().velocidade * Time.deltaTime);
        }
        if (barqueiro.transform.position.x - player.transform.position.x <= -0.3 && player.transform.position.x < 107)
        {
            player.GetComponent<Animator>().SetBool("isRunning", false);
            barqueiro.GetComponent<Animator>().SetBool("Moving", true);
            barqueiro.transform.Translate(Vector2.right * player.gameObject.GetComponent<PlayerController>().velocidade * Time.deltaTime);
            //this.gameObject.SetActive(false);
        }
        else if (player.transform.position.x >= 107)
        {
            player.GetComponent<PlayerController>().enabled = true;
            barqueiro.GetComponent<Animator>().SetBool("Moving", false);
            this.gameObject.SetActive(false);
        }
    }
}
