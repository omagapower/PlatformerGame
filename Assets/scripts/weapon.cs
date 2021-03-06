using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    //public LineRenderer linerenderer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //StartCoroutine(Shoot());
            Shoot();
        }
    }

    /*IEnumerator*/void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        RaycastHit2D rayhit = Physics2D.Raycast(firePoint.position, firePoint.right);

        /*if (rayhit)
        {
            enemy Enemy = rayhit.transform.GetComponent<enemy>();
            if (Enemy)
            {
                Enemy.takeDamage(20f);
            }

            linerenderer.SetPosition(1, rayhit.point);

            
            
        }
        else {
            linerenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        linerenderer.enabled = true;

        yield return 0;
        //yield return new WaitForSeconds(0.02f);

        linerenderer.enabled = false;

    */
    }
}
