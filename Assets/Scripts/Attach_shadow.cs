using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach_shadow : MonoBehaviour {

    public GameObject shadow;
    private float img_height, img_width;
    // Use this for initialization
    void Start () {
        img_height = shadow.gameObject.GetComponent<RectTransform>().rect.height * this.transform.localScale.x;
        img_width = shadow.gameObject.GetComponent<RectTransform>().rect.width * this.transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update () {
        shadow.transform.position = this.transform.position + new Vector3(0, -img_height/2, 0) ;
	}
}
