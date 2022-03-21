using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    private int timer = 0;
    private int interval = 300;

    [SerializeField]
    private Transform firePoint;

    [SerializeField]
    private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;

        if (timer % interval == 0) 
        {
            Shoot();
        }
    }

    public void Shoot() 
    {
        Instantiate(projectile, firePoint.position, firePoint.rotation);
    }
}
