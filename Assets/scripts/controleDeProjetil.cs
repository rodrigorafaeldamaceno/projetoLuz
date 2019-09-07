using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleDeProjetil : MonoBehaviour {

    private void OnCollisionEnter (Collision other) {
        var atingido = other.gameObject;

        if (atingido.CompareTag ("Macron")) {
            float randomX = UnityEngine.Random.Range (-15, 15);
            float randomZ = UnityEngine.Random.Range (-15, 15);

            GameObject macronzinho = Instantiate (Resources.Load ("Macron", typeof (GameObject))) as GameObject;

            macronzinho.transform.position = new Vector3 (randomX, 1, randomZ);
            macronzinho.transform.rotation = Quaternion.Euler (0, UnityEngine.Random.Range (0, 360), 0);

            Destroy (atingido);
            Destroy (gameObject);
        }
    }
}