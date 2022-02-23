using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    static int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,bulletSpeed,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        score++;
        print("score=" + score);
        UIManager.scoreValue += 1;
        Destroy(collision.gameObject);

    }
}
