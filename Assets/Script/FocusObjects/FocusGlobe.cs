using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusGlobe : MonoBehaviour {
    GameObject globe;

    private void Start()
    {
        globe = GameObject.Find("Globe");

        globe.SetActive(false);
    }

    private void OnMouseDown()
    {
        globe.SetActive(true);
    }
}
