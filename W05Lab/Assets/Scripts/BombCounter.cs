using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCounter : MonoBehaviour {

    public GameObject bomb;
    public GameObject objectToSpawn1;
    GameObject explosion;
    Vector3 spawnPosition1;

    // Use this for initialization
    void Start () {
        StartCoroutine(Explode());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Explode()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.0f);
            Destroy(bomb);
            spawnPosition1 = bomb.transform.position;
            spawnPosition1.z = 0.0f;
            explosion = Instantiate(objectToSpawn1, spawnPosition1, Quaternion.Euler(new Vector3(0, 0, 0)));

        }


    }
}
