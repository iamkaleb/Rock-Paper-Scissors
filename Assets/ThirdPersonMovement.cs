using System;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 8f;
    public Manager manager;

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(horizontal, 0, vertical).normalized;

        if(direction.magnitude >= 0.1)
        {
            var targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation =Quaternion.Euler(0, targetAngle, 0);

            controller.Move(direction * speed * Time.deltaTime);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        Console.WriteLine(collision);
        if (collision.gameObject.name == "Rock")
        {
            manager.Play("Rock");
        }
        if (collision.gameObject.name == "Paper")
        {
            manager.Play("Paper");
        }
        if (collision.gameObject.name == "Scissors")
        {
            manager.Play("Scissors");
        }
    }

}
