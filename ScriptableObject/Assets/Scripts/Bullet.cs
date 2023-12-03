using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float life = 3;
    
    public PowerUp PowerUp;
 
    void Awake()
    {
        Destroy(gameObject, life);
    }
 
    void OnCollisionEnter2D(Collision2D collision)
    {

            if(collision.gameObject.CompareTag("PowerUp")){
                Destroy(gameObject);
                Gun.bSpeed*=PowerUp.bulletSpeed;
                Gun.dmg+=PowerUp.damage;
            }else{
                Obstacle.health-=Gun.dmg;
                if(Obstacle.health <= 0){
                    Destroy(collision.gameObject);
                    Obstacle.health=0;
                } 
                Debug.Log("remaining health "+Obstacle.health);
                Destroy(gameObject);
            }
        
        
    }
}
