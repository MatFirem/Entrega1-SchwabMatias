using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour
{

    public GameObject cabezaTorre;
    public Transform bulletSpawn;
    public GameObject cannon;
    public int damage;
    public int life;
    public float rangeAttack;
    public GameObject rangeAttackOb;
    public GameObject bulletReference;
    public float fireRate;
    void Start()
    {
        rangeAttackOb.GetComponent<SphereCollider>().radius = rangeAttack;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
