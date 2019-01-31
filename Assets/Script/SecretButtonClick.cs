using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButtonClick : MonoBehaviour {
    GameObject box1;
    GameObject box2;
    GameObject text1;
    GameObject text2;

    void Start () {
        box1 = GameObject.Find("SecretBox1");
        box2 = GameObject.Find("SecretBox2");
        text1 = GameObject.Find("SecretText1");
        text2 = GameObject.Find("SecretText2");

        box1.SetActive(false);
        box2.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
    }

    void OnMouseDown () {
        box1.SetActive(true);
        box2.SetActive(true);
        text1.SetActive(true);
        text2.SetActive(true);
    }
}
