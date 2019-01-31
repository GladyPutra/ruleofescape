using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorScript : MonoBehaviour {
    GameObject canvas, canvas2;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");

        canvas.SetActive(false);
    }
    private void OnMouseDown()
    {
        canvas.SetActive(true);
    }
}
