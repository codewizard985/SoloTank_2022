using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [SerializeField] protected int LifePoint = 1;
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected float DelayValue = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

    protected void Fire()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
    }

    // update is called once per frame
    private void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(BulletSpawnPosition.transform.position,BulletSpawnPosition.transform.up,out hit))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f);
            Fire();
        }
    }
}
