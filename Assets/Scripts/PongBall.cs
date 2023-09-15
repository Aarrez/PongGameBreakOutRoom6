using UnityEngine;

public class PongBall : MonoBehaviour
{
    public float Speed = 10.0f;
    
    private Vector2 direction;

    private void Start()
    {
        direction = new Vector2(1, 1).normalized;
    }

    private void Update()
    {
        transform.position += (Vector3)direction * (Speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var surfaceNormal = collision.contacts[0].normal;
        
        direction = Vector2.Reflect(direction, surfaceNormal);
        
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
    }
    

    
}