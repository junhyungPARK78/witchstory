using UnityEngine;
using System.Collections;

public class BG_Move : MonoBehaviour {

	public float _speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(_speed * Time.deltaTime, 0, 0);

		if (transform.localPosition.x < -2560.0f) 
		{
			transform.localPosition = new Vector3 (-1280.0f, 0, 0);
		}

	}
}
