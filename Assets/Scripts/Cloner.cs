using UnityEngine;

public class Cloner : MonoBehaviour 
{

	public MonoBehaviour Script;
	public int Total;

	private void Awake () 
	{
		for (var i = 0; i < Total; i++)
		{
			gameObject.AddComponent(Script.GetType());
		}
	}
	
}
