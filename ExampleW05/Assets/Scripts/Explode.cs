using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public float explosionRadius = 50.0f;
    public float explosionForce = 1.0f;

    private Rigidbody rBody;
    private RaycastHit2D[] hits;

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody>();

        hits = Physics2D.CircleCastAll(this.transform.position, explosionRadius, Vector2.zero);

        foreach(RaycastHit2D h in hits)
        {
            if(h.transform.gameObject.tag == "Crate")
                h.rigidbody.AddForce((h.transform.position - this.transform.position) * explosionForce, ForceMode2D.Impulse);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
