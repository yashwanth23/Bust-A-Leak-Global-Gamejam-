using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_movement : MonoBehaviour {

    public float sun_away_angle;

    public float timer;

    private float screen_angle;

    private float sun_angle_initial, sun_angle_final, sun_angle;
    private float a, b;

    private float theta = 0;
    private float x, y;

    public float timeDelay;
    public GameObject instructions;
    public SpriteRenderer sun;
    public float sunAlpha;

    // Use this for initialization
    void Start () {
        sunAlpha = 2;
        sun = this.gameObject.GetComponent<SpriteRenderer>(); 
        //a = Screen.width;
        //b = Screen.height;

        b = Camera.main.orthographicSize * 2 - 0.5f;
        a = b * Screen.width / Screen.height;
        Debug.Log(new Vector2(a, b));

        screen_angle = Mathf.Rad2Deg * Mathf.Atan2((Screen.width / 2), Screen.height);
        //Debug.Log(screen_angle);

        sun_angle_initial = 90 + screen_angle + sun_away_angle;
        sun_angle_final = 90 - screen_angle - sun_away_angle;
        sun_angle = sun_angle_initial - sun_angle_final;

        this.transform.position = new Vector2(a * Mathf.Cos(Mathf.Deg2Rad * sun_angle_initial), b * Mathf.Sin(Mathf.Deg2Rad * sun_angle_initial));
        

    }

    // Update is called once per frame
    void Update () {

        //Start moving when timer hits 0
        if(timeDelay <= 0)
        {
            if(instructions != null)
            Destroy(instructions);

            theta += sun_angle / (timer * 100);

            if (theta < sun_angle)
            {
                x = a * Mathf.Cos(Mathf.Deg2Rad * (sun_angle_initial - theta));
                y = b * Mathf.Sin(Mathf.Deg2Rad * (sun_angle_initial - theta));

                sunAlpha -= Time.deltaTime/60;
                sun.color = new Color(sun.color.r, sun.color.g, sun.color.b, sunAlpha);
            }
        }
        else{
            timeDelay -= Time.deltaTime;
        }



        this.transform.position = new Vector2(x, y);

    }

    public void skipDelay()
    {
        timeDelay = 0;
    }
}
