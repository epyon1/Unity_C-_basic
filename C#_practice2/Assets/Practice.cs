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
        hello(name);  //関数helloを呼び出す．引数はname
        greet(17);  //greet関数の呼び出し
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void hello(string name)  //関数hello
    {
        string words = name + "さん，こんにちは";
        print(words);  //アラカワさんこんにちは
    }
    void greet(int hour)
    {
        if (hour >= 5 && hour <= 10)
        {
            print("おはようございます");
        }
        else if (hour >= 11 && hour <= 17)
        {
            print("こんにちは");
        }
        else
        {
            print("こんばんは");
        }

    }
}
