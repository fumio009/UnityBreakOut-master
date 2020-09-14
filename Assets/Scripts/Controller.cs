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
                        left_proc();
                        pos = t.position.x;
                    }
                    else if (pos < t.position.x)
                    {
                        right_proc();
                        pos = t.position.x;
                    }
                    if (pos_y > t.position.y)
                    {
                        down_proc();
                        // transform.position -= vy * 0.05f;
                        pos_y = t.position.y;
                    }
                    else if (pos_y < t.position.y)
                    {
                        up_proc();
                        // transform.position += vy * 0.05f;
                        pos_y = t.position.y;
                    }
                }
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left_proc();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            right_proc();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            up_proc();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            down_proc();
        }
        // transform.LookAt(Vector3.zero);
        transform.LookAt(new Vector3(10.0f, 0.5f, 0));

        Vector3 position = transform.position;
        if (position.y > 1.0f)
        {
            position.y = 0.5f;
            transform.position = position;
        }
    }

    void left_proc()
    {
        // transform.position += transform.forward * 0.1f;
        transform.position += v * 0.1f;
        // transform.Rotate(new Vector3(0, 1, 0), 1);
        // transform.Rotate(5.0f, 0.0f, 0.0f, Space.World);
        // transform.rotation= new Vector3(0f, 0f, 0f);;
        // transform.LookAt(Vector3.zero);
    }
    void right_proc()
    {
        // transform.position -= transform.forward * 0.1f;
        transform.position -= v * 0.1f;
        // transform.Rotate(new Vector3(0, 1, 0), -1);
    }
    void up_proc()
    {
        transform.position += vy * 0.05f;
    }
    void down_proc()
    {
        transform.position -= vy * 0.05f;
    }
}
