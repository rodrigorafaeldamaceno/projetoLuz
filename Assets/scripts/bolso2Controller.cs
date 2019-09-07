using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolso2Controller : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform projetilSpawn;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dispara();
        }

    }

    private void Dispara()
    {
        var projetil = (GameObject)Instantiate(projetilPrefab,
            projetilSpawn.position,
            projetilSpawn.rotation);

        projetil.GetComponent<Rigidbody>().velocity = projetil.transform.forward * 20.0f;
        AudioSource som = GetComponent<AudioSource>();
        som.Play();

        Destroy(projetil, 4.0f);
    }
}
