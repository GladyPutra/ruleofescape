using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusGlasses : MonoBehaviour {
    GameObject glasses;

    private void Start()
    {
        glasses = GameObject.Find("Glasses");

        glasses.SetActive(false);
    }

    private void OnMouseDown()
    {
        glasses.SetActive(true);
    }
}
