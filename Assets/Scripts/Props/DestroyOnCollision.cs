using UnityEngine;
using System.Collections;

/*
 * Destory objects when they collide with deadly tagged objects and bullets
 * When we destory show some body parts!
 */

public class DestroyOnCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Deadly")
        {
            
            if (target.gameObject.layer == LayerMask.NameToLayer("Bullet"))
            {
                ZombieManager.zombieCount++;
                Destroy(target.gameObject);
            }

            OnDestroy();
        }
    }

    void OnDestroy()
    {
        Destroy(gameObject);
    }

}
