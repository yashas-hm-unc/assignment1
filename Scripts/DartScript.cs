using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DartScript : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.CompareTag("target10"))
        {
            ScoreScript.ScoreCount += 10;
            Destroy(gameObject);
        }
        
        if (col.gameObject.CompareTag("target5"))
        {
            ScoreScript.ScoreCount += 5;
            Destroy(gameObject);
        }
        
        if (col.gameObject.CompareTag("target1"))
        {
            ScoreScript.ScoreCount += 1;
            Destroy(gameObject);
        }
    }
}
