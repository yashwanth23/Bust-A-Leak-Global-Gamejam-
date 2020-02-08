using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crack_spawn : MonoBehaviour {

    private float b_width, b_height;
    public GameObject crack;
    public GameObject parent;
    public Sun_movement sun;

    //private GameObject[] stored_cracks;
    public float crack_delay;
    private int count, i;
	// Use this for initialization
	void Start () {
        b_height = Camera.main.orthographicSize * 2;
        b_width = b_height * Screen.width / Screen.height;
        count = 0;
        i = 0;
        //stored_cracks = new GameObject[];
	}
	
	// Update is called once per frame
	void Update () {

        if (sun.timeDelay <= 0f)
        {
            count++;
            if (count % crack_delay == 0)
            {
                float x = Random.Range(-b_width / 2, b_width / 2);
                float y = Random.Range(0, b_height / 3);
                GameObject newCrack = Instantiate(crack, new Vector2(x, y), Quaternion.identity, parent.transform) as GameObject;
                //stored_cracks.Push(newCrack);
                //Debug.Log(stored_cracks);
            }
        }
	}
}
