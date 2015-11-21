using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Collider2D))]
[RequireComponent (typeof(SpriteRenderer))]
public class InteractableObject : MonoBehaviour {

	SpriteRenderer collisionArea;
	CursorSpriteController masterController;

	// Use this for initialization
	void Start () {
		collisionArea = GetComponent<SpriteRenderer> ();
		masterController = GameObject.Find ("Cursor Sprite").GetComponent<CursorSpriteController>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		print ("Yay!");
		//pass to character, move character, character interacts with object
	}

	public void OnCharacterInteract(GameObject character){

	}

	void OnMouseEnter(){
		masterController.CursorOnObject (gameObject);
	}

	void OnMouseLeave(){
		masterController.CursorLeaveObject (gameObject);
	}
}
