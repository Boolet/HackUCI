using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CursorSpriteController : MonoBehaviour {

	List<GameObject> insideObjects;

	// Use this for initialization
	void Start () {
		insideObjects = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (insideObjects.Count > 0) {
			//interact indication
		} else {
			//passive mode
		}
	}

	public void CursorOnObject(GameObject onObject){
		if(!insideObjects.Contains(onObject)){
			insideObjects.Add(onObject);
		}
	}

	public void CursorLeaveObject(GameObject onObject){
		if(insideObjects.Contains(onObject)){
			insideObjects.Remove(onObject);
		}
	}
}
