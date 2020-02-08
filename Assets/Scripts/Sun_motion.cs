using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_motion : MonoBehaviour {
    
    public float timer;

    private Vector2 initial, final;
    private float r, angle_i, angle_f, sun_angle;
    private float theta = 0;
    private float x, y;
    private Vector2 origin;
	// Use this for initialization
	void Start () {
        //this.gameObject.transform.position = new Vector2(-Screen.width / 2 - 2, Screen.height / 2 + 2);
        Application.targetFrameRate = 100;
        initial = this.gameObject.transform.position;
        final = new Vector2(-this.gameObject.transform.position.x, this.gameObject.transform.position.y);

        origin = new Vector2(0, 0);

        r = Vector2.Distance(initial, origin);

        angle_i = Mathf.Rad2Deg * Mathf.Atan2(initial.y, initial.x);
        angle_f = Mathf.Rad2Deg * Mathf.Atan2(final.y, final.x);
        sun_angle = angle_i - angle_f;
        //Debug.Log(new Vector2(r*Mathf.Cos(Mathf.Deg2Rad*angle_i), r * Mathf.Sin(Mathf.Deg2Rad * angle_i)));
        Debug.Log(sun_angle);
    }
	
	void Update () {

        theta += sun_angle / (timer * 100);        

        if(theta < angle_i - angle_f)
        {
            x = r * Mathf.Cos(Mathf.Deg2Rad*(angle_i - theta));
            y = r * Mathf.Sin(Mathf.Deg2Rad * (angle_i - theta));
        }
        

        this.transform.position = new Vector2(x, y);

        
	}
}
