﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivabilityManager : MonoBehaviour {

    public GameObject player;
    public GameObject hp;
    private int temp;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        hp.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(player.GetComponent<PlayerController>().hp, hp.GetComponent<Image>().rectTransform.sizeDelta.y);
    }
}
