using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCalculator : MonoBehaviour {
    GameObject calc;

    private void Start()
    {
        calc = GameObject.Find("Calculator");

        calc.SetActive(false);
    }

    private void OnMouseDown()
    {
        calc.SetActive(true);
    }
}
