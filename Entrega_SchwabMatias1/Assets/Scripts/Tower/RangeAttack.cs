using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    TowerControl tcRoot;
    float timeNextBullet;
    public Transform bPosition;
    private void Start()
    {
        tcRoot = transform.parent.gameObject.GetComponent<TowerControl>();
    }
    private void OnTriggerStay(Collider obj)
    {
        switch(obj.tag)
        {
            case "Enemy":
                tcRoot.cabezaTorre.transform.LookAt(obj.transform);
                if(Time.time > timeNextBullet)
                {
                    Instantiate(tcRoot.bulletReference, tcRoot.bulletSpawn.position, tcRoot.bulletSpawn.rotation);
                    timeNextBullet = Time.time + tcRoot.fireRate;
                    
                }
                
            break;
        }
    }
}
