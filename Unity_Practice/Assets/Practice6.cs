using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice6 : MonoBehaviour {

    public int sum;
    //public int i;

	// Use this for initialization
	void Start () {

        for (int i = 1; i <= 20; i++)
        {
            Debug.Log(i);
            sum += i;
        }
        Debug.Log(sum);

            ;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
