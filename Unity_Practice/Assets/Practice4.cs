using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice4 : MonoBehaviour {
    public string name ;

	// Use this for initialization
	void Start () {
        Choice(name);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Choice(string n)
    {
        switch (n)
        {
            case "山田":
                Debug.Log("私は山田という人を知っています");
                break;
            case "松下":
                Debug.Log("私は松下という人を知っています");
                break;
            default:
                Debug.Log("私はその人を知りません");
                break;
        }
    }   
}