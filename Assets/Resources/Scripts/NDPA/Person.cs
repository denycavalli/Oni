﻿using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour 
{

	public NavMeshHit mypoint;
	NavMeshAgent agent;

	void Start () 
	{
	}
	public float range = 10.0f;
	bool RandomPoint(Vector3 center, float range, out Vector3 result) 
	{
		for (int i = 0; i < 30; i++) 
		{
			Vector3 randomPoint = center + Random.insideUnitSphere * range;
			NavMeshHit hit;
			if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, 1)) 
			{
				result = hit.position;
				return true;
			}
		}
		result = Vector3.zero;
		return false;
	}
	void Update () 
	{
		/*Vector3 point;
		if (RandomPoint(transform.position, range, out point)) 
		{
			agent.destination = point;
		}*/
	}
}
