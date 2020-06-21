using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoyController
{
    public class Enemy : MonoBehaviour
    {
        BoyController _player;
        private void Awake()
        {
            _player = GameObject.FindObjectOfType<BoyController>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                _player.ResetPosition();
            }
        }
    }
}
