using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_motion : MonoBehaviour {

    public float timer;
    public float moon_end_angle;

    private Vector2 initial, final;
    private float r, angle_i, angle_f;
    private float theta = 0;
    private float x, y;
    private Vector2 origin;
    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 100;
        //this.gameObject.transform.position = new Vector2(-Screen.width / 2 - 2, Screen.height / 2 + 2);

        initial = this.gameObject.transform.position;
        final = new Vector2(-this.gameObject.transform.position.x, this.gameObject.transform.position.y);

        origin = new Vector2(0, 0);

        r = Vector2.Distance(initial, origin);

        angle_i = Mathf.Rad2Deg * Mathf.Atan2(initial.y, initial.x);
        angle_f = angle_i - moon_end_angle;
        //Debug.Log(new Vector2(r*Mathf.Cos(Mathf.Deg2Rad*angle_i), r * Mathf.Sin(Mathf.Deg2Rad * angle_i)));
        Debug.Log(moon_end_angle);
    }

    void Update()
    {

        theta += moon_end_angle / (timer * 100); ;

        if (theta < angle_i - angle_f)
        {
            x = r * Mathf.Cos(Mathf.Deg2Rad * (angle_i - theta));
            y = r * Mathf.Sin(Mathf.Deg2Rad * (angle_i - theta));
        }
        

        this.transform.position = new Vector2(x, y);

    }
}
