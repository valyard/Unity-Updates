using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	private void Update () 
	{
		if (Input.anyKeyDown)
		{
			Application.LoadLevel((Application.loadedLevel + 1) % Application.levelCount);
		}
	}
}
