using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float speedOfSpin = 180f;

    private void Start()
    {
        speedOfSpin = (Random.Range(-360f, 360f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speedOfSpin * Time.deltaTime);
    }
}
