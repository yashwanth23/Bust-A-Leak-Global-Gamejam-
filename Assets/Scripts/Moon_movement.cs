using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_movement : MonoBehaviour {

    public float moon_away_angle;
    public float moon_angle;

    public float timer;

    private float screen_angle;

    private float moon_angle_initial, moon_angle_final;
    private float a, b;

    private float theta = 0;
    private float x, y;

    public ScreenFader sf;

    // Use this for initialization
    void Start()
    {

        //a = Screen.width;
        //b = Screen.height;

        b = Camera.main.orthographicSize * 2 - 1;
        a = b * Screen.width / Screen.height;
        Debug.Log(new Vector2(a, b));

        screen_angle = Mathf.Rad2Deg * Mathf.Atan2((Screen.width / 2), Screen.height);
        //Debug.Log(screen_angle);

        moon_angle_initial = 90 + screen_angle + moon_away_angle;
        moon_angle_final = moon_angle_initial - moon_angle;

        this.transform.position = new Vector2(a * Mathf.Cos(Mathf.Deg2Rad * moon_angle_initial), b * Mathf.Sin(Mathf.Deg2Rad * moon_angle_initial));


    }

    // Update is called once per frame
    void Update()
    {
        theta += moon_angle / (timer * 100);

        if (theta < moon_angle)
        {
            x = a * Mathf.Cos(Mathf.Deg2Rad * (moon_angle_initial - theta));
            y = b * Mathf.Sin(Mathf.Deg2Rad * (moon_angle_initial - theta));
        }
        else if(theta > moon_angle)
        {
            sf.start(4, 0f);
        }


        this.transform.position = new Vector2(x, y);

    }
}
