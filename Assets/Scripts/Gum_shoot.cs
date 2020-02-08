using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gum_shoot : MonoBehaviour {

    public GameObject gum;
    public int Score = 0;

    public Text ChangeText;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if(hit == true && Input.GetMouseButton(0))
        {
            if(hit.transform.gameObject.tag == "glow_crack")
            {
                Instantiate(gum, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                Score++;
                ChangeScore();
            }
        }

        
    }

    public void ChangeScore()
    {
        ChangeText.text = Score.ToString();
    }
    
}
