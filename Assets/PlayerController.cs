using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Vector3 MoveVertical(Vector3 v, KeyCode key, float value){
		if (Input.GetKey(key)){
			v.z += value;
		}
		return v;
	}

	Vector3 MoveHorizontal(Vector3 v, KeyCode key, float value){
		if (Input.GetKey(key)){
			v.x += value;
		}
		return v;
	}

	Vector3 Move(Vector3 v){
		float speed = 0.2f;
		v = MoveHorizontal (v, KeyCode.LeftArrow,  speed);
		v = MoveHorizontal (v, KeyCode.RightArrow, -1 * speed);
		v = MoveVertical   (v, KeyCode.UpArrow,    -1 * speed);
		v = MoveVertical   (v, KeyCode.DownArrow,  speed);
		return v;
	}

	void Update () {
		this.transform.position = Move(this.transform.position);
	}
}
