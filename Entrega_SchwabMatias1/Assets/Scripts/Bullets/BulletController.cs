using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public int enemysDies;
    private void Start()
    {

    }
    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Impact Area":
                collision.collider.transform.root.gameObject.GetComponent<Enemy>().lifeEnemy -= 5;
                Destroy(this.gameObject);
                break;


        }
    }
}


