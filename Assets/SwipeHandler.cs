using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount >0)
		{
			Swipe();
		}
	}
	void Swipe()
	{
		Vector2 delta = Input.GetTouch(0).deltaPosition;

		if(Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
		{
			if(delta.x >0)
			{
				Debug.Log("Right");
			}
			else
			{
				Debug.Log("Left");
			}
		}
		else
		{
			if(delta.y>0)Debug.Log("Up");
			else Debug.Log("Down");
		}
	}
}
