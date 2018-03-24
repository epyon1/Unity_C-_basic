using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //このパッケージをいれることで、Canvas上のTextなどをプログラムで使用できるようになる

public class Sample : MonoBehaviour {
    public Text text;  //Textオブジェクトが代入される変数textの宣言

    // Use this for initialization
    void Start () {
        string str = "Hello World!";
        ShowMessage(str);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void ShowMessage (string s)
    {
        text.text = s;  //実際に文字を表示させる
    }
}
