using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisca : MonoBehaviour
{
     
    private float timer = 1;
    public KeyCode keyboard;
    public Light[] lights;
		private bool status = true;
   
   void Update () { 
      if (Input.GetKeyDown(keyboard)){
				status = !status;
			}
			if(status){
				timer -= Time.deltaTime;
				foreach (Light light in lights){
					if(timer < 0){
						light.enabled = !light.enabled;
						timer = 0.2f; // o segredo esta aqui xD
					}
				}
			}
   }
}

