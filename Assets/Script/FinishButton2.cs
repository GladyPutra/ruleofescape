﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishButton2 : MonoBehaviour {
	GameObject in1, in2, in3, in4;
	InputField if1, if2, if3, if4;

	private void Start()
	{
		GameObject canvas = GameObject.Find ("Canvas");

		canvas.SetActive (true);
	}

	public void OnClick()
	{
		in1 = GameObject.Find("InputField1");
		in2 = GameObject.Find("InputField2");
		in3 = GameObject.Find("InputField3");
		in4 = GameObject.Find("InputField4");

		if1 = in1.GetComponent<InputField>();
		if2 = in2.GetComponent<InputField>();
		if3 = in3.GetComponent<InputField>();
		if4 = in4.GetComponent<InputField>();

		if (if1.text == "Iota" && if2.text == "Beta" && if3.text == "Alpha" && if4.text == "Omega")
			SceneManager.LoadScene ("Scene6c");
		else
			SceneManager.LoadScene ("Scene6");
	}
}
