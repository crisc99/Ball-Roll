using UnityEngine;
using System.Collections;

// Cristian Cruz
// Rotator

public class Rotator : MonoBehaviour {

	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}	