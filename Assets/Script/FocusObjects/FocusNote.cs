using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusNote : MonoBehaviour {
    GameObject note;

    private void Start()
    {
        note = GameObject.Find("Note");

        note.SetActive(false);
    }

    private void OnMouseDown()
    {
        note.SetActive(true);
    }
}
