using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarSol : MonoBehaviour
{
    public Light[] lights;
	public KeyCode keyboard;

	void Update ()
	{
		foreach (Light light in lights)
		{
			if (Input.GetKeyDown(keyboard))
			{
				light .enabled = !light .enabled;
			}
		}
	}
}
