using UnityEngine;
using System.Collections;

public class BlockType1 : BlockMaster {
    public override void blockFunction()
    {
        ball.GetComponent<PlayerController>().speed += 1;
        Debug.Log("Overriding");
    }
}
