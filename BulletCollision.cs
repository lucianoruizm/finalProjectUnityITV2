using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    [SerializeField] GameObject explotion;
    [SerializeField] AudioSource asExplotionSound;
    [SerializeField] AudioClip explotionSound;
    [SerializeField] int damageAmmount = 10;
    [SerializeField] int damageAmmountBoss = 20;
    GameObject gameManager;
    GameController gameController;

    void Start()
    {
        gameManager = GameObject.Find("GameController");

        if(gameManager == null) Debug.Log("GameManager Object not found");

        gameController = gameManager.GetComponent<GameController>();

        if(gameController == null) Debug.Log("GameController Script not found");
    }

    private void OnCollisionEnter(Collision other)
    {   
        if(other.gameObject.CompareTag("Enemy"))
        {
            gameController.ScoreUp(damageAmmount);
            Instantiate(explotion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            asExplotionSound.PlayOneShot(explotionSound);

            Destroy(gameObject, 2.0f);
        }

        else if(other.gameObject.CompareTag("EnemyBoss"))
        {
            gameController.ScoreUp(damageAmmountBoss);

            Instantiate(explotion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            asExplotionSound.PlayOneShot(explotionSound);
        
            Destroy(gameObject, 2.0f);
        }
    }
}
