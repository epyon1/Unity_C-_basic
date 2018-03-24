using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour {
    public Text text;

    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

	// Use this for initialization
	void Start () {
        Days day = Days.Monday;  //DaysからMondayを取得し，変数dayに代入
        switch (day)
        {
            case Days.Sunday:
                text.text = "日曜日です";
                break;
            case Days.Monday:
                text.text = "月曜日です";
                break;
            case Days.Tuesday:
                text.text = "火曜日です";
                break;
            case Days.Wednesday:
                text.text = "水曜日です";
                break;
            case Days.Thursday:
                text.text = "木曜日です";
                break;
            case Days.Friday:
                text.text = "金曜日です";
                break;
            case Days.Saturday:
                text.text = "土曜日です";
                break;
            default:
                text.text = "どの曜日でもありません";
                break;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
