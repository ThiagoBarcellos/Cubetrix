﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.game;
public class Name : MonoBehaviour {
    ServiceAPI serviceapi;
    public GameObject digname,btOk;
    private TouchScreenKeyboard keyboarrd; 
	string name; 


	float deltaTime = 0.0f;
	void Awake()
	{
		
	}
	// Use this for initialization
	void Start () {
		//PlayerPrefs.DeleteAll ();


			
		name = PlayerPrefs.GetString("nome");
        serviceapi = new ServiceAPI("fc1ab1a6bc1505b184f09e1fbe499a61edec16818ea13d07cdb85482b19d6342", "ad67abfb73dcd7ec24e353d705fb0a1212900958f2b79682ffec2d7b68bc2384");
		Debug.Log("nome e "+name);

		if (!PlayerPrefs.HasKey("nome")) {
			digname.SetActive (true);
			Debug.Log ("qualnome");

		} else {
			digname.SetActive (false);
			Debug.Log ("temnome");
		}
        if (GameObject.Find("playername") != null && GameObject.Find("playername").GetComponent<Text>().text == "" )
       {
           btOk.SetActive(false);
       }


    }
	
	// Update is called once per frame
	void Update () {


	}
    public void btok()
    {
        if (GameObject.Find("playername").GetComponent<Text>().text != "") { 
        PlayerPrefs.SetString("nome", GameObject.Find("playername").GetComponent<Text>().text);
        digname.SetActive(false);
			mudardecena.soundClick ();
    }}
    public void showOK()
    {
       btOk.SetActive(true);


    }


}
