using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBShoot : MonoBehaviour
{
    public Vector2[] muzzlePositions = new Vector2[2];
    public float bulletSpeed = 6;
    public float reloadTime = 0.5f;
    float reloadTimer;

    public GameObject bulletPrefab;
    private AudioSource shootSrc;

    private void Awake()
    {
        shootSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (reloadTimer > 0)
            reloadTimer -= Time.deltaTime;
        else
            reloadTimer = 0;

        bool shoot = Input.GetKey("space") && reloadTimer <= 0;

        if (shoot)
        {
            reloadTimer = reloadTime;
            foreach (Vector2 item in muzzlePositions)
            {
                Vector3 offset = item;
                GameObject bullet = Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletSpeed);
            }

            shootSrc.Stop();
            shootSrc.Play();
        }
    }
}
