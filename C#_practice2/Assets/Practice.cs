using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour {
    public Text text;

	// Use this for initialization
	void Start () {
        int num = 3;
        if (num > 1)
        {
            text.text = "1より大きいです";
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
