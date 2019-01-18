using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				Debug.Log(hit.collider.name);
				Click clicker = hit.collider.GetComponent<Click>();
				if (clicker != null)
				{
					clicker.ObjectClicked();
					return;
				}
				BoolSetter boolSetter = hit.collider.GetComponent<BoolSetter>();
				if (boolSetter != null)
				{
					boolSetter.ToggleBool();
					return;
				}
				
			}
		}
	}
}
