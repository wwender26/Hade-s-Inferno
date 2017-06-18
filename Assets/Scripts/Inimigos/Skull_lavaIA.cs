﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull_lavaIA : MonoBehaviour {

    public GameObject player;
    private Rigidbody2D body;
    private float velocidade = 1f;
    public bool move = false;

    // Use this for initialization
    void Start () {
        body = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (System.Math.Abs(player.transform.position.x - this.transform.position.x) <= 4) move = true;
        if (!this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("dead") && move)
        {
            if (player.transform.position.x <= this.transform.position.x)
            {
                Debug.Log("a");
                body.AddForce(Vector2.left * velocidade);
                transform.eulerAngles = new Vector2(0, 0);
            }
            else
            {
                Debug.Log("b");
                transform.eulerAngles = new Vector2(0, 180);
                body.AddForce(Vector2.right * velocidade);
            }
            if (player.transform.position.y <= this.transform.position.y) body.AddForce(Vector2.down * velocidade);
            else body.AddForce(Vector2.up * velocidade);
        }
        else if(this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("dead")) body.AddForce(Vector2.down * 10);
    }
}
