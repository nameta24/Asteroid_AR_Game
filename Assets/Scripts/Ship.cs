using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject _ship;
    public Vector3 TranslationVector;

    public void Update()
    {
        _ship.transform.Translate(TranslationVector * Time.deltaTime);
    }
}
