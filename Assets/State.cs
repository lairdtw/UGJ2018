using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch(FoodGenerator.state){
            case FoodGenerator.State.Start: text.text = "點擊開始";
                break;
            case FoodGenerator.State.Die:
                text.text = " 你死了 ";
                break;
            case FoodGenerator.State.Next:
                text.text = " 你贏了 ";
                break;
            case FoodGenerator.State.Play:
                text.text = "";
                break;
        }
	}
}
