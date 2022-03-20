using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    private float nextActionTime = 1f;
    public float period = 1f;

    [SerializeField]
    private Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            Debug.Log("yoyoyoyoyoyoyo");
        }
    }
}
