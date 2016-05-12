using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody ball;

    public int speed = 1;

    public int direction = 2;

	// Use this for initialization
	void Start () {
        ball.AddForce(Vector3.right * speed);
    }
	
	// Update is called once per frame
	void Update () {
        MoveBall();
        if (direction > 3){
            direction -= 4;
        }
        else if (direction < 0){
            direction += 4;
        }
	}

    void MoveBall(){
        int directionSwitch = 1;
        bool movingHorizontal = false;

        switch (direction){
            case 0:
                directionSwitch = -1;
                movingHorizontal = true;
                break;
            case 1:
                directionSwitch = -1;
                movingHorizontal = false;
                break;
            case 2:
                directionSwitch = 1;
                movingHorizontal = true;
                break;
            case 3:
                directionSwitch = 1;
                movingHorizontal = false;
                break;
        }
        if (movingHorizontal)
            ball.MovePosition(transform.position + (transform.right * speed * directionSwitch * Time.deltaTime));
        else
            ball.MovePosition(transform.position + (transform.forward * speed * directionSwitch * Time.deltaTime));
    }
}
