using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State : MonoBehaviour {

    public Text text;
    public AudioSource LoopMusic;
    public GameObject g1;
    public GameObject g2;


	// Use this for initialization
	void Start () {
		G1 = Instantiate(g1, new Vector3(0,0,0), Quaternion.identity);
        G1.SetActive(false);
        G2 = Instantiate(g2, new Vector3(0, 0, 0), Quaternion.identity);
        G2.SetActive(false);
    }
    public GameObject G1;
    public GameObject G2;
	// Update is called once per frame
	void Update () {
        switch(FoodGenerator.state){
            case FoodGenerator.State.Start: text.text = "點擊開始";
                LoopMusic.clip = Resources.Load<AudioClip>("Music/Game");
                LoopMusic.Play();
                break;
            case FoodGenerator.State.Die:
                G1.SetActive(true);
                //Resources.Load("Imgs/BadEnd");
                text.text = " 你死了 ";
                break;
            case FoodGenerator.State.Next:

                G2.SetActive(true);
                //Resources.Load("Imgs/GoodEnd");
                text.text = " 你贏了 ";
                break;
            case FoodGenerator.State.Play:
                text.text = "";
                G1.SetActive(false);
                G2.SetActive(false);
                break;
        }
	}
}
