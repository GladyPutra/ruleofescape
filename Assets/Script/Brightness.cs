using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour {
	Slider brightness;
	float val;

	public void Update()
	{
		brightness = GameObject.Find ("BrightnessSlider").GetComponent<Slider> ();

		val = brightness.value;
	}

	public void Change()
	{
		RenderSettings.ambientLight = new Color (val, val, val, 1);
	}
}
