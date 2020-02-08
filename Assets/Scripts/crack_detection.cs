using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crack_detection : MonoBehaviour {

    public GameObject h_crack, n_crack;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "crack")
        {
            Instantiate(h_crack, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "crack")
        {
            Instantiate(h_crack, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "glow_crack")
        {
            GameObject old_crack = Instantiate(n_crack, collision.transform.position, Quaternion.identity);
            old_crack.GetComponent<AudioSource>().enabled = false;
            Destroy(collision.gameObject);
        }
    }
}
