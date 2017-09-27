using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstCamera : MonoBehaviour {

    public Transform player;
    //don't use GameObject because it'll take all of its components

    //refers to Transform component of camera
    private Transform camTrans;
    //private Camera camCam;

    // Use this for initialization
    void Start()
    {
        camTrans = this.transform;
        //shortcut for camTrans = this.GetComponent<Transform>(); (available since Transform is a common component)
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x <= -3.2)
        {
            camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
        }

        else if (player.position.x > -3.2 && player.position.x <= 3.2)
        {
            camTrans.position = new Vector3(0, 0, camTrans.position.z);
            Camera.main.orthographicSize = 1.85f;
        }

        else if (player.position.x > 3.2)
        {
            camTrans.position = new Vector3(6.37f, 0, camTrans.position.z);

            if (player.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                Camera.main.orthographicSize -= 0.01f;
            }

            if (player.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
            {
                Camera.main.orthographicSize += 0.01f;
            }
        }
    }
}
