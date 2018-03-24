using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string name = "kento";
        int birthMonth = 6;
        int birthDay = 9;
        int Sum = birthMonth += birthDay;
        //Sum(birthMonth, birthDay);
        print("私の名前は" + name + "です．生まれた月の数字と生まれた日にちを足すと" + Sum +"になります．");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //int Sum(int a, int b)
    //    int a = birthMonth;
    //int b = birthDay;
    //    return a + b ;
}
