using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour {

    private Gum_shoot gs;
    public Text score;

	// Use this for initialization
	void Start () {
        GameObject.Find("Main Camera").GetComponent<Gum_shoot>();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "SCORE: "+gs.Score;
	}
}
