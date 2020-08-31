using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private float pos;
    private float pos_y;
    private Vector3 v = new Vector3(0, 0, 1);
    private Vector3 vy = new Vector3(1, 0, 0);
    //	private Vector3 r = new Vector3(0,1,0);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            foreach (Touch t in Input.touches)
            {
                if (t.phase == TouchPhase.Began)
                {
                    pos = t.position.x;
                    pos_y = t.position.y;
                }
                else if (t.phase == TouchPhase.Moved)
                {
                    if (pos > t.position.x)
                    {
                        // transform.position += transform.forward * 0.1f;
                        transform.position += v * 0.1f;
                        transform.Rotate(new Vector3(0, 1, 0), 1); ;
                        pos = t.position.x;
                    }
                    else if (pos < t.position.x)
                    {
                        // transform.position -= transform.forward * 0.1f;
                        transform.position -= v * 0.1f;
                        transform.Rotate(new Vector3(0, 1, 0), -1); ;
                        pos = t.position.x;
                    }
                    if (pos_y > t.position.y)
                    {
                        transform.position -= vy * 0.05f;
                        pos_y = t.position.y;
                    }
                    else if (pos_y < t.position.y)
                    {
                        transform.position += vy * 0.05f;
                        pos_y = t.position.y;
                    }
                }
            }
        }

        // if (Input.GetKey(KeyCode.LeftArrow)) {
        //     transform.position += transform.forward * 0.1f;
        // }else if (Input.GetKey(KeyCode.RightArrow)) {
        //     transform.position -= transform.forward * 0.1f;
        // }
    }
}
