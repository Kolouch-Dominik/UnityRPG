using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [field: SerializeField] public Transform Target { get; set; }

        private void LateUpdate()
        {
            transform.position = Target.position;
        }
    }
}