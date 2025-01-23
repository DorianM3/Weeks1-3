using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletSpawnTank : MonoBehaviour
{
    public GameObject prefab;
    public GameObject explosion; 
    public Transform SpawnLocation; 
    public BulletTank bullet;
    public Transform ExplosionLocation; 
    public List <GameObject> spawnedBulletsList;
    //public List<GameObject> explosionList;


    void Start()
    {
        spawnedBulletsList = new List<GameObject>();
        Spawn();
    }

    void Update()
    {
      for (int i = 0; i < spawnedBulletsList.Count; i++)
        {
         if (spawnedBulletsList[i].transform.position.x > 2)
           {
              GameObject store = spawnedBulletsList[i];
              spawnedBulletsList.Remove(store);
              Destroy(store);
              GameObject GO = Instantiate(explosion, ExplosionLocation);
              //explosionList.Add(explosion); 
              Destroy(GO, 1);
           }
        }
        if (bullet == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
        GameObject spawnedBullet = Instantiate(prefab, SpawnLocation);
        bullet = spawnedBullet.GetComponent<BulletTank>();
        spawnedBulletsList.Add(spawnedBullet);

    }

    void Fire()
    {
        bullet.hasBeenFired = true;
        bullet = null; 
    }
}
