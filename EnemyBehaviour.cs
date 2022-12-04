using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float alertRange;
    public LayerMask playerLayer;
    bool alertState;
    public Transform p1;
    public float speed;
    public static EnemyBehaviour enemyBehaviour;
    public int health;

    void Start()
    {
        enemyBehaviour = this;
    }

    void Update()
    {
       alertState = Physics.CheckSphere(transform.position,alertRange,playerLayer);

       if(alertState == true)
       {
          transform.LookAt(p1);
          transform.position = Vector3.MoveTowards(transform.position, new Vector3(p1.position.x,transform.position.y,p1.position.z), speed * Time.deltaTime);
       }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Projectile"))
        {
            health -= 1;
            Debug.Log(health);
            if(health == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    // Con la siguiente función se dibuja una esfera del tamaño de la esfera
    // creada con alertRange, de esta forma se visualiza el rango que tiene esta esfera
    private void OnDrawGizmos() 
    {
        //Esto le da color la esfera, puede servir en caso de tener
        //una gran cantidad de enemigo con deferentes rangos de alerta
        Gizmos.color = Color.yellow;
        //Dibuja la esfera
        Gizmos.DrawWireSphere(transform.position, alertRange);    
    }
}
