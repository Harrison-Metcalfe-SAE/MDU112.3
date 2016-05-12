using UnityEngine;
using System.Collections;

public class BlockType3H : BlockMaster
{

    public override void blockFunction()
    {
        Debug.Log("Overriding");
        if (ball.GetComponent<PlayerController>().direction % 2 == 0)
        {
            ball.GetComponent<PlayerController>().direction += 2;
        }
        else
        {
            ball.GetComponent<PlayerController>().direction += 3;
        }
    }
}


