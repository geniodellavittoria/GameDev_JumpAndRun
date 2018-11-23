using Assets.GameObjects.Character;
using System;
using UnityEngine;

namespace Assets.Controllers
{
    public class InputController :MonoBehaviour
    {
        public event Action Jump = delegate { };
        public event Action MoveBack = delegate { };
        public event Action MoveForward = delegate { };
        public event Action Shoot = delegate { };

        protected static InputController s_Instance;

        public static InputController Instance
        {
            get
            {
                return s_Instance;
            } 
        }

        void Start()
        {
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
            if (Input.GetKey(KeyCode.A))
            {
                MoveForward();   
            }
            if (Input.GetKey(KeyCode.D))
            {
                MoveBack();
            }
        }

    }
}
