using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float _speed;
	public GameObject[] _EnemySetObj;

	// Use this for initialization
	void Start () {
	

		_EnemySetObj [0].transform.localPosition += new Vector3 (0, Random.Range (-2, 3) * 130.0f, 0);
		_EnemySetObj [1].transform.localPosition += new Vector3 (0, Random.Range (-2, 3) * 130.0f, 0);
		_EnemySetObj [2].transform.localPosition += new Vector3 (0, Random.Range (-2, 3) * 130.0f, 0);
		_EnemySetObj [3].transform.localPosition += new Vector3 (0, Random.Range (-2, 3) * 130.0f, 0);

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (_speed * Time.deltaTime, 0, 0);

	}
}
