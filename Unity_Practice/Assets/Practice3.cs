using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice3 : MonoBehaviour {
    public int num;
    public int nuu;



    // Use this for initialization
    void Start()
    {
        Choice1(num);
        Choice2(num);
        Choice3(num);
        Debug.Log(nuu);
        //    if (num == 0)
        //    {
        //        print("値は0だよ");
        //    }
        //    else
        //    {
        //        print("値は0ではないよ");
        //    }
        //}
    }
    // Update is called once per frame
    void Update() {

    }



    void Choice1 (int n)
    {
        if (n == 0){
            Debug.Log("値は０だよ");
        }else{
            Debug.Log("値は０ではないよ");
        }
    }

    void Choice2 (int m)
    {
        if (m < 20){
            Debug.Log("値は20より小さいよ");
        }else if ( m<40 ){
            Debug.Log("値が40より小さいよ");
        }else{
            Debug.Log("値は40以上だよ");
        }
    }

    int Choice3 (int l)
    {
        if (l > 10)
        {
            Debug.Log("10より大きい数から1を引いたよ");
            nuu = l - 1;
            return nuu;
        }else {
            return -1;
        }
    }


}        


