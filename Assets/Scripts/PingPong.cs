using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PingPong : MonoBehaviour
{
    private float move; 
    private float speed = 5f;

    private Vector2 some;
    private Vector3 initPos;


    private void Start()
    {
        initPos = transform.position;
    }

    public void MoveRectangle(InputAction.CallbackContext ctx)
    {
        move = ctx.ReadValue<float>();
        some = Vector2.up * (move * speed * Time.deltaTime);
    }

    private void Update()
    {
        float posY = transform.position.y + move * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, Math.Clamp(posY, -5.5f, 5.5f), transform.position.z);
    }
}
