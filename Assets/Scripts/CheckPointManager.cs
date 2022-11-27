using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour {
	
	[HideInInspector] public Vector3 lastCheckPointPos;
	
	#region Singleton pattern
	private static CheckPointManager _instance;
	public static CheckPointManager Instance
	{
		get 
		{
			if (!_instance)
				_instance = FindObjectOfType<CheckPointManager>();
			return _instance;
		}
	}
	#endregion

	void Start()
	{
		lastCheckPointPos = new Vector3(-105, 0, 0);
	}
}
