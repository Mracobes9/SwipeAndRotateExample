﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTouchHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
		Debug.Log("Local touch");
	}
}
