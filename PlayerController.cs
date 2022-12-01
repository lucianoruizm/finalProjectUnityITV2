using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    float deltaRotation = 30f;
    float deltaMovement = 7f;
    public bool gameOver;

    void FixedUpdate()
    {
        
        // Vector3 movementInput = Vector3.zero;

        // if(Input.GetKey(KeyCode.W))
        // {
        //     movementInput.z = 1;
        // }
        // else if(Input.GetKey(KeyCode.S))
        // {
        //     movementInput.z = -1;
        // }

        
        // if(Input.GetKey(KeyCode.D))
        // {
        //     movementInput.x = 1;
        // }
        // else if(Input.GetKey(KeyCode.A))
        // {
        //     movementInput.x = -1;
        // }

        // Move(movementInput);
        Movement();
        Rotate();

        
    }

    // void Move(Vector3 direction)
    // {
    //     transform.position += direction.normalized * speed * Time.deltaTime;
    // }

    void Rotate ()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, deltaRotation, 0f) * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * speed * Time.deltaTime);
        }
    }

    void Movement ()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            gameOver = true;

            gameObject.SetActive(false);
            GameOverManager.gameOverManager.CallGameOver();
        }
    }
}
