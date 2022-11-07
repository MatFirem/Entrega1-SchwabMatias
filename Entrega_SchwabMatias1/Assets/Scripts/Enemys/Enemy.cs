using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int lifeEnemy = 20;
    public GameManager contador;
   
    
    void Update()
    {
        if (lifeEnemy >= 0)
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else
        {
            Destroy(this.gameObject);
            
        }

        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Way Point")
        {
            target = other.gameObject.GetComponent<WayPoints>().nextPoint;
            transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
        }
        if (other.tag == "End")
        {
            contador.gameObject.GetComponent<GameManager>().sumarContador();
                       Destroy(this.gameObject);        
        }

    }

   


}

