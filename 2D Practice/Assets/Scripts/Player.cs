using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SJ.Player
{
    public class PlayerInput : MonoBehaviour
    {
        private string verticalInputName = "Vertical";
        private string horizontalInputName = "Horizontal";

        public float VerticalInput { get; private set; }
        public float HorizontalInput { get; private set; } 

        private void Update()
        {
            VerticalInput = Input.GetAxis(verticalInputName);
            HorizontalInput = Input.GetAxis(horizontalInputName);
        }
    }
}

