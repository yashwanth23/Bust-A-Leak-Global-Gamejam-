using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon_trigger : MonoBehaviour {
    private float b_width, b_height;
    public GameObject Moon;

    void Start()
    {
        b_height = Camera.main.orthographicSize * 2 - 1;
        b_width = b_height * Screen.width / Screen.height;
        this.transform.position = new Vector2(b_width / 2 - 1, b_height - 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Sun")
        {
            Moon.SetActive(true);
            Debug.Log("Sun hit");
        }
    }
}
