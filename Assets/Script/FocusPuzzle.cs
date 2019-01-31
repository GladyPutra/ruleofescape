using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPuzzle : MonoBehaviour {
	GameObject puzzle;

	private void Start()
	{
		puzzle = GameObject.Find("SecretPuzzle");

		puzzle.SetActive(false);
	}

	private void OnMouseDown()
	{
		puzzle.SetActive(true);
	}
}
