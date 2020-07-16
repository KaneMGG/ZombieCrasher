﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{

	private Transform target;

	public float distance = 6.3f;
	public float height = 3.5f;

	public float height_Damping = 3.25f;
	public float rotation_Damping = 0.27f;

	[SerializeField]
	private float shakeDuration = 0f;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;

	//Vector3 originalPos;

	public void ShakeCamera(float duration)
    {
		shakeDuration = duration;

	}




	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void LateUpdate()
	{
		FollowPlayer();
	}

	void FollowPlayer()
	{

		float wanted_Rotation_Angle = target.eulerAngles.y;
		float wanted_Height = target.position.y + height;

		float current_Rotation_Angle = transform.eulerAngles.y;
		float current_Height = transform.position.y;

		current_Rotation_Angle = Mathf.LerpAngle(
			current_Rotation_Angle, wanted_Rotation_Angle, rotation_Damping * Time.deltaTime);

		current_Height = Mathf.Lerp(
			current_Height, wanted_Height, height_Damping * Time.deltaTime);

		Quaternion current_Rotation = Quaternion.Euler(0f, current_Rotation_Angle, 0f);

		transform.position = target.position;
		transform.position -= current_Rotation * Vector3.forward * distance;

		transform.position = new Vector3(transform.position.x, current_Height, transform.position.z);


		if (shakeDuration > 0)
		{
			transform.localPosition = transform.position + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
			transform.localPosition = transform.position;
		}
	}

} // class