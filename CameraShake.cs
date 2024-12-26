using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public float shakeStrength = 2f;
    public float shakeDuration = 0.4f;

    private float shakeTimer;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            
            float x = Mathf.PerlinNoise(Time.time * 10, 0) - 0.5f;
            float y = Mathf.PerlinNoise(0,Time.time * 10) - 0.5f;

            transform.position = originalPosition + new Vector3(x, y, 0) * shakeStrength;
        }
        else
        {
            transform.position = originalPosition;
        }
    }

    public void Shake()
    {
        shakeTimer = shakeDuration;
    }
}
