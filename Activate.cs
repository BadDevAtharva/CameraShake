using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    [SerializeField] private CameraShake cameraShake;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            explosion.SetActive(true);
            cameraShake.Shake();
        }
    }
}
