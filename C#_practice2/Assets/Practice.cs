using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    public Text text;

    
	// Use this for initialization
	void Start () {
        hello();  //関数の呼び出し
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void hello()
    {
        print("hello world");
    }
}
