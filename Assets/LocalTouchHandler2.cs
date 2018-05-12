using UnityEngine;
using UnityEngine.EventSystems;

public class LocalTouchHandler2 : MonoBehaviour, IPointerDownHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log("Poiner Down");
	}
}
