using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float _speed =-5.0f;
	private float _halfHeight;

	// Use this for initialization
	void Start () {
	
		_halfHeight = Screen.height * 0.5f;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.touchCount > 0)
		{
			float _deltaPosY = Input.GetTouch (0).position.y - _halfHeight;
			float _Ypos = _deltaPosY - transform.localPosition.y;
			Debug.Log (_Ypos);
			transform.Translate (0,_speed * Time.deltaTime * _Ypos * 0.01f,0);
		}

			transform.localPosition = new Vector3 (transform.localPosition.x,
		                                       Mathf.Clamp (transform.localPosition.y, -270f, 250f),
		                                       transform.localPosition.z);


	}
}
