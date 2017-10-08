using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    GameObject objectInstance;
    Vector3 spawnPosition;

    //public GameObject objectToSpawn1;
    //GameObject explosion;
    //Vector3 spawnPosition1;

    public float explosionRadius = 50.0f;
    public float explosionForce = 1.0f;

    private Rigidbody rBody;
    private RaycastHit2D[] hits;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnPosition.z = 0.0f;
            objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));

            //Destroy(objectInstance, 3);
            
            
            //Explode();

        }
    }

    //IEnumerator Explode()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(3.0f);
    //        Destroy(objectInstance);
    //        spawnPosition1 = objectInstance.transform.position;
    //        spawnPosition1.z = 0.0f;
    //        explosion = Instantiate(objectToSpawn1, spawnPosition1, Quaternion.Euler(new Vector3(0, 0, 0)));
           
    //    }

      
    //}
}
