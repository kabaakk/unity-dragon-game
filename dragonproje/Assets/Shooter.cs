using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    private Vector3 offsetProjectile = new Vector3(2, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    public void Attack()
    {
        var projectile = Instantiate(projectilePrefab, transform.position + offsetProjectile, projectilePrefab.transform.rotation);
    }
}
