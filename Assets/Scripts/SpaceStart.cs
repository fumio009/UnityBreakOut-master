using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0)
		{
			foreach(Touch t in Input.touches)
			{
				if (t.phase == TouchPhase.Began)
				{
					// Debug.Log("fid=" + t.fingerId + " x=" + t.position.x + " y=" +  t.position.y);
            		SceneManager.LoadScene("Main");
				}
			}
		}
        // if (Input.GetKey(KeyCode.Space)) {
        //     SceneManager.LoadScene("Main");
        // }
    }
}
