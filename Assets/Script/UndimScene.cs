using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndimScene : MonoBehaviour {
    GameObject dim;

    public void OnClick()
    {
        dim = GameObject.Find("Dim");

        dim.GetComponent<Renderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        dim = GameObject.Find("Dim");

        dim.GetComponent<Renderer>().enabled = false;
    }
}
