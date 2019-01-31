using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToAbout : MonoBehaviour {
	public void OnClick()
	{
		SceneManager.LoadScene("About");
	}
}
