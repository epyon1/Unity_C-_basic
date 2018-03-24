using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    public Text text;

    
	// Use this for initialization
	void Start () {
        string name = "アラカワ";  //変数nameの宣言と代入
        hello(name);  //関数の呼び出し
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void hello(string name)  //関数hello
    {
        string words = name + "さん，こんにちは";
        print(words);
    }
}
