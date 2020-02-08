using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_img : MonoBehaviour {

    public float speed = 2f;
    public float rot_time;
    private Quaternion target_rot;
    public float target_rotation;
	// Use this for initialization
	void Start () {
        target_rot = Quaternion.Euler(0, 0, target_rotation); 
    }
	
	// Update is called once per frame
	void Update () {
		if(Time.deltaTime*100 < rot_time)
        {
            Debug.Log("Rotating");
            float step = speed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target_rot, step);
        }
	}
}
