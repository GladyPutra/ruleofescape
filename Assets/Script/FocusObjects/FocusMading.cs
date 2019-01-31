using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusMading : MonoBehaviour {
    GameObject mading;

    private void Start()
    {
        mading = GameObject.Find("Mading");

        mading.SetActive(false);
    }

    private void OnMouseDown()
    {
        mading.SetActive(true);
    }
}
