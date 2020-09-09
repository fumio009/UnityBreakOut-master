using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour
{
    Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0, 0.4f, 0);
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        // transform.eulerAngles = new Vector3(45, 90, 0);
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * 500);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 8 || transform.position.x < -8)
        {
            transform.position = new Vector3(0, 0.4f, 0);
        }
        if (rigid.velocity.magnitude < 10f)
        {
            rigid.AddForce(transform.forward * 500);
        }
    }
}
