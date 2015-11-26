using UnityEngine;
using System.Collections.Generic;

public class UpdateManager : MonoBehaviour 
{

	private List<ManagedUpdateBehavior> list;

	private void Start () 
	{
		list = new List<ManagedUpdateBehavior>(GetComponents<ManagedUpdateBehavior>());
	}
	
	private void Update () {
		var count = list.Count;
		for (var i = 0; i < count; i++)
		{
			list[i].UpdateMe();
		}
	}
}
