using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float shotForce = 1500;
    [SerializeField] float shotRate = 0.5f;
    private float shotRateTime = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.O))
        {
           if (Time.time>shotRateTime)
           {
             GameObject newBullet;

             newBullet = Instantiate(projectilePrefab,spawnPoint.position, spawnPoint.rotation);
    
             newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

             shotRateTime = Time.time + shotRate;

             Destroy(newBullet,3.0f);
           }
        }
    }
}
