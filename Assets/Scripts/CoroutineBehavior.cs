using UnityEngine;
using System.Collections;

public class CoroutineBehavior : MonoBehaviour {

    private int i;

	private void Start() 
    {
	   StartCoroutine(MyUpdate());
	}
    
    private IEnumerator MyUpdate()
    {
        while (true)
        {
            yield return null;
            i++;
        }
    }
}
