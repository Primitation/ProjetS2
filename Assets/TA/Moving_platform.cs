using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
	public Transform target;
	public float speed;

	private Vector3 start;
	private Vector3 end;

	// Use this for initialization
	void Start()
	{
		start = transform.position;
		end = target.position;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		if (transform.position == target.position)
		{
			target.position = (target.position == start) ? end : start;
		}
	}
}
