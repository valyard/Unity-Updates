using UnityEngine;
using System.Diagnostics;
using System.Collections;

public class Counter : MonoBehaviour 
{

	public float StartTime = 1f;

	private Stopwatch sp;
	private long total;
	private long num;
	private long last;
	
	private void Awake()
	{
		sp = new Stopwatch();
		StartCoroutine(log());
	}
	
	private void Update () 
	{
		if (Time.time < StartTime) return;
		sp.Start();	
	}
	
	private void LateUpdate()
	{
		if (Time.time < StartTime) return;
		sp.Stop();
		num++;
		last = sp.ElapsedTicks;
		total += last;
		sp.Reset();
	}
	
	private IEnumerator log()
	{
		var delay = new WaitForSeconds(1f);
		while (true)
		{
			yield return delay;
			if (num > 0) UnityEngine.Debug.Log("Last time: " + (float)last/Stopwatch.Frequency*1000f + "ms. Average time: " + (float)(total/num)/Stopwatch.Frequency*1000f + "ms.");
		}
	} 
	
}
