using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float _speed =-5.0f;
	private float _halfHeight;

	// Use this for initialization
	void Start () {
	
		_halfHeight = Screen.height * 0.5f;

		if (_anim == null)
		{

			GetComponent<Animation>()["0_idle"].layer = 0;
			GetComponent<Animation>()["1_damage"].layer = 1;
			GetComponent<Animation>()["1_damage"].speed = 5.0f;

		}


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

	public Animator _anim;
	public int _hp = 100;
	void OnTriggerEnter(Collider other)
	{
		_hp--;

		 if (_anim != null)
		{
			_anim.SetBool("damageChk",true);
		}
		else
		{
			GetComponent<Animation>().Play("1_damage");
		}

	}

	void DamageEnd()
	{
		_anim.SetBool("damageChk", false);
	}

}
