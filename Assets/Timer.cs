using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text text;
    public static float timer;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (FoodGenerator.state != FoodGenerator.State.Play) return;

        timer -= Time.deltaTime;
        text.text = timer+"";

        if(timer<0){
            if (Bar.food <= 86 && Bar.food >= 68) FoodGenerator.state = FoodGenerator.State.Next;
            else FoodGenerator.state = FoodGenerator.State.Die;
        }
	}

    /*IEnumerator levelTime()
    {
        yield return new WaitForSeconds(30.0f);
    }*/
}

