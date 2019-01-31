using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusObject : MonoBehaviour {
    GameObject secretObj;

    private void Start()
    {
        secretObj = GameObject.Find("SecretObject");

        secretObj.SetActive(false);
    }

    private void OnMouseDown()
    {
        secretObj.SetActive(true);
    }
}
