using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{

	[SerializeField] private Material myColor;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			myColor.color = Color.green;
		}
	}
}
