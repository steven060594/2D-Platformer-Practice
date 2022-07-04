using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SJ.Player
{
    public class PlayerManager : MonoBehaviour
    {
        PlayerInput playerInput;

        private void Awake()
        {
            playerInput = new PlayerInput();
        }

        private void Update()
        {

        }
    }
}

