using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public void StartGame()
	{
		SceneManager.LoadScene (2);
	}

    private void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
