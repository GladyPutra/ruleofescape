using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseObject : MonoBehaviour {
    public void OnClick()
    {
        this.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
