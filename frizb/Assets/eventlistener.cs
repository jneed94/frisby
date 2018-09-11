using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventlistener : MonoBehaviour {
private Renderer _renderer;
	// Use this for initialization
	void Start () {
		_renderer = gameObject.GetComponent<Renderer> (); 
	}
	
	public void OnEnter() {
		_renderer.material.color = Color.red;
	}

	public void OnExit() {
		_renderer.material.color = Color.white;
	}
	public void OnGrab() {
		Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
		transform.SetParent (pointerTransform, true);
		transform.localPosition = new Vector3(0, 0, 1);
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;
	}

	public void OnRelease() {
		transform.SetParent (null, true);
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.useGravity = true;
	}

}
