using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimScene : MonoBehaviour {
    GameObject dim;

    private void Start()
    {
        dim = GameObject.Find("Dim");

        dim.GetComponent<Renderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        dim.GetComponent<Renderer>().enabled = true;
    }
}
