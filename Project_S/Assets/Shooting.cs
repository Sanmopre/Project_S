using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint_2;
    public Transform firePoint_3;

    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bullet_2 = Instantiate(bulletPrefab, firePoint_2.position, firePoint_2.rotation);
        GameObject bullet_3 = Instantiate(bulletPrefab, firePoint_3.position, firePoint_3.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        Rigidbody2D rb_2 = bullet_2.GetComponent<Rigidbody2D>();
        rb_2.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        Rigidbody2D rb_3 = bullet_3.GetComponent<Rigidbody2D>();
        rb_3.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }


}
