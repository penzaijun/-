﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayingSceneUI : MonoBehaviour {

    public GameObject InterSceneData;
    
	// Use this for initialization
	void Start ()
    {
        InterSceneData = GameObject.Find("InterSceneData");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackToMain()
    {
        GameObject player = GameObject.Find("Player");
        int starnum = player.GetComponent<PlayerController>().getF();
        SceneManager.LoadScene("Main");
        GameObject root = GameObject.Find("Main Camera");
        GameObject Welcome = root.GetComponent<MainSceneManager>().Welcome;
        GameObject Choose = root.GetComponent<MainSceneManager>().Choose;
        Debug.Log("delete");
        Welcome.SetActive(false);
        Choose.SetActive(true);
    }
}
