using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    [SerializeField] GameObject explotion;
    [SerializeField] AudioSource asExplotionSound;
    [SerializeField] AudioClip explotionSound;

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
}
