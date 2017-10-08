using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryoByTime : MonoBehaviour {

    public float timeToDestroy = 1.0f;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timeToDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
