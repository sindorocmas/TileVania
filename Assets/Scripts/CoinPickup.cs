using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int pointForCoinPickup = 100;

    bool wasCollected = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindAnyObjectByType<GameSession>().AddToScore(pointForCoinPickup);
            AudioSource.PlayClipAtPoint(coinPickupSFX,Camera.main.transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
