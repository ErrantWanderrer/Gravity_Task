using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float asteroidSpeed;
    
    public Vector3 sunPos;
    public GameObject asteroid;

    public float gVect;
    public float sunMass;
    private float G;

    void Start()
    {
        G = 1;
        sunPos = new Vector3(0f, 0f, 0f);
    }
    
    void Update()
    {
        gVect = (G * sunMass) / (Mathf.Pow(asteroid.transform.position.x, 2) + Mathf.Pow(asteroid.transform.position.z, 2));
        transform.Translate(Vector3.right * (asteroidSpeed * Time.deltaTime));
        Vector3 dir = (sunPos - transform.position).normalized;
        Vector3 delta = dir * (gVect * Time.deltaTime);
        transform.Translate(delta);
    }
}
