using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickIf : MonoBehaviour
{
	public List<bool> requiredBools;
	public Transform onClickGoTo;
	public void ObjectClicked()
	{
		for (int i = 0; i < GetComponent<Click>().possibleBools.Count; i++)
		{
			if (requiredBools[i] != GetComponent<Click>().possibleBools[i].state)
			{
				Debug.LogError("return");
				return;
			}
		}
		Vector3 goTo = new Vector3(onClickGoTo.position.x, onClickGoTo.position.y, onClickGoTo.position.z - 1);
		Camera.main.transform.position = goTo;
	}
}
