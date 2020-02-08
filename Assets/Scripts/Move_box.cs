using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_box : MonoBehaviour {

    private float b_width, b_height;
    private float img_width;

    private Vector2 current_position; 
    private float step;
    private float start, end;

    // Use this for initialization
    void Start () {
        b_height = Camera.main.orthographicSize * 2;
        b_width = b_height * Screen.width / Screen.height;

        img_width = this.gameObject.GetComponent<RectTransform>().rect.width * this.transform.localScale.x;

        this.transform.position = new Vector2(- b_width / 2 + img_width/2, b_height / 3);

        step = img_width;

        start = -b_width / 2 + img_width / 2;
        end = b_width / 2 - img_width;
    }
	
	// Update is called once per frame
	void Update () {
        current_position = this.transform.position;
         
        if (Input.GetKeyDown(KeyCode.A) && current_position.x > start)
        {
            this.transform.position = new Vector2(current_position.x - step, current_position.y);
        }
        if (Input.GetKeyDown(KeyCode.D) && current_position.x < end)
        {
            this.transform.position = new Vector2(current_position.x + step, current_position.y);
        }
        
	}
}
