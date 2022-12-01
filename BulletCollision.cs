using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    [SerializeField] GameObject explotion;
    [SerializeField] AudioSource asExplotionSound;
    [SerializeField] AudioClip explotionSound;
    public int enemyHealth = 0;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(explotion, other.gameObject.transform.position, other.gameObject.transform.rotation);

            asExplotionSound.PlayOneShot(explotionSound);
            
            Destroy(other.gameObject);

            Destroy(gameObject, 2.0f);
        }
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     damage = damage + 1;
        
    //     if(other.gameObject.CompareTag("EnemyBoss"))
    //     {   
    //         if(damage == 3)
    //         {
    //             Instantiate(explotion, other.gameObject.transform.position, other.gameObject.transform.rotation);

    //             asExplotionSound.PlayOneShot(explotionSound);
                
    //             Destroy(other.gameObject);
                
    //             Destroy(gameObject, 2.0f);
    //         }

    //     }
    // }
}
