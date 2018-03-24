using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    public Text text;

    
	// Use this for initialization
	void Start () {
        int total = 0;
        for (int i = 1; i <= 10; i++)
        {
            total+=i;
        }
        text.text = "合計：" + total;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
