using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpawn : MonoBehaviour {

    public GameObject bomb;

    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            print(Input.mousePosition);
            Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
            print(p);
            print(p.x);
            print(p.y);

            Instantiate(bomb, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);

        }
    }
}
