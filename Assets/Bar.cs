using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {
    public static double Food=0, Goal=100;
    public Image cooldown;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cooldown.fillAmount += 1.0f / 30 * Time.deltaTime;
    }
}
