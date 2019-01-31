using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic1 : MonoBehaviour {
	AudioSource cd;

	private void Start()
	{
		cd = this.gameObject.GetComponent<AudioSource> ();
	}

    private void OnMouseDown()
    {
		cd.PlayOneShot (cd.clip);
    }
}
