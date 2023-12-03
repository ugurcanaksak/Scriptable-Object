using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;

    private int CSpeed=5;
    static public float bSpeed = 10;

    static public int dmg = 10;
    [SerializeField] Rigidbody2D rb;
    private void Awake(){
        rb=GetComponent<Rigidbody2D>();
    }
    
 
    void Update()
    {
        move();
        shoot();
    }

    public void move()
    {
        var HorizontalInput = Input.GetAxis("Horizontal");

       if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Translate(Vector2.right * HorizontalInput * Time.deltaTime * CSpeed);
        }
    }

    public void shoot(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bSpeed;
        }
    }
}
