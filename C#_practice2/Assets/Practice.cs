﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour {
    public Text text;

	// Use this for initialization
	void Start () {
        int num = 0;
        if (num > 0)
        {
            text.text = "値は正です";
        }else if(num==0){
            text.text = "値は0です";
        }
        else
        {
            text.text = "値は負です";
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
