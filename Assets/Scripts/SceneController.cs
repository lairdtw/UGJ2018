using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public AudioSource LoopMusic;

	// Use this for initialization
	void Start () {
        LoopMusic.clip = Resources.Load<AudioClip>("Music/Logo");
        LoopMusic.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)){
            SceneManager.LoadScene(1);
        }
	}
}
