using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text tuspuntos;
    public Text record;

	// Use this for initialization
	void Start () {

        tuspuntos.text = "YOUR SCORE:\n"+PlayerPrefs.GetInt("punt").ToString();
        record.text = "RECORD SCORE:\n" + PlayerPrefs.GetInt("max").ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
