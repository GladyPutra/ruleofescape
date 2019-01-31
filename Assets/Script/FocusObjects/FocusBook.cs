using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusBook : MonoBehaviour {
    GameObject book;

    private void Start()
    {
        book = GameObject.Find("Book");

        book.SetActive(false);
    }

    private void OnMouseDown()
    {
        book.SetActive(true);
    }
}
