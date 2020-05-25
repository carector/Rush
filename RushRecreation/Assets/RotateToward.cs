using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToward : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 targetVector = target.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(targetVector);
	}
}
