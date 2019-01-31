using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToNextInput : MonoBehaviour {
    GameObject t1, t2, t3, t4;

    private void Start()
    {
        t1 = GameObject.Find("InputField1");
        t2 = GameObject.Find("InputField2");
        t3 = GameObject.Find("InputField3");
        t4 = GameObject.Find("InputField4");
    }

    public void To2nd()
    {
        EventSystem.current.SetSelectedGameObject(t2);
    }

    public void To3rd()
    {
        EventSystem.current.SetSelectedGameObject(t3);
    }

    public void To4th()
    {
        EventSystem.current.SetSelectedGameObject(t4);
    }

    public void To1st()
    {
        EventSystem.current.SetSelectedGameObject(t1);
    }
}
