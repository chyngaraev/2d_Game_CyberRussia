using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace BoyController
{
    
    public class ExitDoor : MonoBehaviour
    {
        public static Action OnFinishLevel = () => { };
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player")) { OnFinishLevel(); }
        }
    }
}
