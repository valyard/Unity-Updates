using UnityEngine;
using System.Collections.Generic;

public class UpdateManager : MonoBehaviour 
{

	private ManagedUpdateBehavior[] list;

	private void Start () 
	{
		list = GetComponents<ManagedUpdateBehavior>();
	}
	
	private void Update () {
		var count = list.Length;
		for (var i = 0; i < count; i++)
		{
			list[i].UpdateMe();
		}
	}
}
