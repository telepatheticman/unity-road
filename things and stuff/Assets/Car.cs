using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public float seconds = 5.0f;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	//	transform.position += transform.right * .1f;
		transform.Translate(Vector3.right * .1f);
	}
	void OnTriggerEnter(Collider other){
	//	Debug.Log ("word");
		if (other.gameObject.CompareTag ("turnR")){
		//	Debug.Log ("other word");
			transform.Rotate(0.0f, 90, 0.0f);
		//	other.gameObject.SetActive(false);
		}
		if (other.gameObject.CompareTag ("turnL")){
		//	Debug.Log ("other word");
			transform.Rotate(0.0f, -90, 0.0f);
		}
		if (other.gameObject.CompareTag ("enter")){

		//	transform.Rotate(90, 0, 0);
			
		}

	}
}
