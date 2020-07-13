using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 地面二つを管理
// GroundBlock Main
// GroundBlock Main2

public class GroundBlock : MonoBehaviour {

	public Transform otherBlock;
	private Transform player;
	private float endOffset = 10f;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		MoveGround ();
	}

	void MoveGround() {
		if (transform.position.z + GameConst.HALFLENGTH < player.transform.position.z - endOffset) {
			
			transform.position = new Vector3 (otherBlock.position.x, otherBlock.position.y,
				otherBlock.position.z + GameConst.HALFLENGTH * 2);
			
		}
	}

} // class








































