using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class SwipeHandler2 : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler {
	
	GameObject gameobject;
	String direction;
	// Use this for initialization
	void Start () {
		direction ="";
	}
	
	// Update is called once per frame
	void Update () {
		
		Transform trans= GameObject.FindWithTag("Player").GetComponent<Transform>();
		switch (direction)
		{
			case "Left":
			{
				trans.rotation *= Quaternion.AngleAxis(1,Vector3.up);
			}break;
			case "Right":
			{
				trans.rotation *= Quaternion.AngleAxis(1,Vector3.down);
			}break;
			case "Up":
			{
				trans.rotation *= Quaternion.AngleAxis(1,Vector3.right);
			}break;
			case "Down":
			{
				trans.rotation *= Quaternion.AngleAxis(1,Vector3.left);
			}break;
			
			default:{}break;
		}
		
	}
	public void OnBeginDrag(PointerEventData eventData)
	{
		Vector2 delta = eventData.delta;
		

		if(Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
		{
			if(delta.x >0)
			{
				Debug.Log("Right");
				direction = "Right";
				
			}
			else
			{
				direction = "Left";
				Debug.Log("Left");
			}
		}
		else
		{
			if(delta.y>0)
			{
				direction = "Up";
				Debug.Log("Up");
				
			}
			else
			{
				direction = "Down";
				Debug.Log("Down");
				
			}
		}
	}
	public void OnDrag(PointerEventData eventData)
	{

	}
	public void OnEndDrag(PointerEventData eventData)
	{

	}
}

