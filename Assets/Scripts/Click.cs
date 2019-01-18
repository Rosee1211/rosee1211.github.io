using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Click : MonoBehaviour
{
	public List<BoolSetter> possibleBools;
	public Transform onClickGoTo;
	public void ObjectClicked()
	{
		if (possibleBools.Count == 0)
		{
			Vector3 goTo = new Vector3(onClickGoTo.position.x, onClickGoTo.position.y, onClickGoTo.position.z - 1);
			Camera.main.transform.position = goTo;
		}
		else
		{
			
			ClickIf[] clickIf = GetComponents<ClickIf>();
			Debug.LogError(clickIf.Length);
			for (int i = 0; i < clickIf.Length; i++)
			{
				clickIf[i].ObjectClicked();
			}
		}

		for (int i = 0; i < possibleBools.Count; i++)
		{
			possibleBools[i].Reset();
		}
	}
}