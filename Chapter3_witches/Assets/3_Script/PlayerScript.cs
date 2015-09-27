using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float _speed = 5.0f;
	private float _halfHeight;

	// Use this for initialization
	void Start () {
	
		_halfHeight = Screen.height * 0.5f;

		//if (_anim != null) 
		//{
			//animation ["0_idle"].layer = 0;
			//animation ["1_damage"].layer = 1;
			//animation ["1_damage"].speed = 5.0f;
		//}
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.touchCount > 0)
		{
			float _deltaPosY = Input.GetTouch(0).position.y - _halfHeight;

			float _Ypos = _deltaPosY - transform.localPosition.y;
			//float _Ypos = _deltaPosY;

			Debug.Log(_Ypos);
			transform.Translate(0,_speed * Time.deltaTime * _Ypos * 0.01f,0);
		}

		transform.localPosition = new Vector3 (transform.localPosition.x,
		Mathf.Clamp(transform.localPosition.y , -270.0f , 250.0f) ,
		transform.localPosition.z);

	}

	public Animator _anim;
	public int _hp = 100;
	public GameObject _DamageEff;


	void OnTriggerEnter(Collider other) {

		_hp--;
		_anim.SetBool ("damageChk", true);

		var _Eff1 = Instantiate (_DamageEff, transform.localPosition,
		                         Quaternion.identity) as GameObject;
		_Eff1.transform.parent = transform;
		_Eff1.transform.localPosition = Vector3.zero;
		_Eff1.transform.localScale = new Vector3 (1, 1, 1);

		//if (_anim != null) 
		//{
			//_anim.SetBool ("damageChk", true);
		//} 
		//else 
		//{
			//animation.Play("1_damage");
		//}

	}

	void DamageEnd()
	{
		_anim.SetBool ("damageChk", false);
	}

}
