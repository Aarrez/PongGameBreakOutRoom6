using System;
using UnityEngine;

public class ResetOnHit : MonoBehaviour
{
    public Action<int> AddScoreLeft, AddScoreRight;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (transform.gameObject.CompareTag("RightPoint"))
        {
            AddScoreRight?.Invoke(1);
            other.gameObject.GetComponent<PongBall>().ResetBall();
            Debug.Log("hit right wall");
        }
        else if (transform.gameObject.CompareTag("LeftPoint"))
        {
            AddScoreLeft?.Invoke(1);
            other.gameObject.GetComponent<PongBall>().ResetBall();
            Debug.Log("hit left wall");
        }
        
        
    }
}
