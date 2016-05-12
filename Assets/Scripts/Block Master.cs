using UnityEngine;
using System.Collections;
using System;

public class BlockMaster : MonoBehaviour {


    public GameObject ball;

    void Update(){
        if (ball == null) {
            ball = GameObject.FindGameObjectWithTag("ball");
            Debug.Log("Identifying Game Object");
        }
    }

    public void OnTriggerEnter(Collider b) {
        blockFunction();
        Debug.Log("BLOCK WORKS");
    }

    public virtual void blockFunction()
    {

    }
}
