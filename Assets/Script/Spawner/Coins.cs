using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private float CoinSpeed;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        Invoke("Destroy", 3);
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
    void Update()
    {
        rb.velocity = Vector2.down * CoinSpeed;
    }
}
