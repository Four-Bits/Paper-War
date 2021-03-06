using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update

    public int enemyHP;
    public bool hasDeathEffect;
    public GameObject DeathEffect;

    public int enemyPoints;

    // Update is called once per frame
    void Update()
    {
        if (enemyHP <= 0)
        {
            if (hasDeathEffect == true)
            {
                Instantiate(DeathEffect, transform.position, transform.rotation);
            }

            GameObject.Find("Canvas").GetComponent<UIScore>().enemyPoints += enemyPoints;
            Destroy(gameObject);
        }
    }
}
