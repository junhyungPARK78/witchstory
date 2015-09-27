using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public GameObject _enemySet;
	public GameObject _nearBgObj;
	public Transform _PlayerObjPool;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	public bool _SpawnChk = true;

	void Update () {
	
		if (_nearBgObj.transform.localPosition.x < -2460.0f && _SpawnChk) 
		{

			var Set1 = Instantiate
				(_enemySet, Vector3.zero,Quaternion.identity) as GameObject;
			Set1.transform.parent = _PlayerObjPool;
			Set1.transform.localScale = new Vector3 (1, 1, 1);
			Set1.transform.localPosition = Vector3.zero;
			_SpawnChk =false;
		
		}

		if(_nearBgObj.transform.localPosition.x > -1300.0f && !_SpawnChk) 
		{
			_SpawnChk = true;
		}


	}
}
