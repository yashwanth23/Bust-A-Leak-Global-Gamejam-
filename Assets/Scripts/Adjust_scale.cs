using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adjust_scale : MonoBehaviour {

    private float b_width, b_height;
    private float img_width, img_height;
    private float scale;

    // Use this for initialization
    void Start () {
        b_height = Camera.main.orthographicSize * 2;
        b_width = b_height * Screen.width / Screen.height;

        img_width = this.gameObject.GetComponent<RectTransform>().rect.width;

        scale = b_width / img_width;
        Vector2 newScale = this.transform.localScale;
        newScale *= scale;
        this.transform.localScale = newScale;
        this.transform.position = new Vector2(0, b_height / 3);
        Debug.Log("New Scale is " + newScale);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
