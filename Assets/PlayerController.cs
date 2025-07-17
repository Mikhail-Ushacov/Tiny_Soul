using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody _rb;

        Vector3 dir;
        public float speed = 8f;
        public bool canMove = true;

        Vector3 dirRoll;
        float rollValue = 50f;
        public bool isRoll = false;
        public bool canRoll = true;

        void Awake()
        { 
            _rb = GetComponent<Rigidbody>();
            _rb.angularDrag = 0.0f;
            //_rb.gravityScale = 0.0f;
            _rb.interpolation = RigidbodyInterpolation.Interpolate;
            _rb.constraints = RigidbodyConstraints.FreezeRotation;
        }

        private void Update()
        {
            InputManager();
        }

        void FixedUpdate()
        {
            if (canMove)
            {
                Move(dir);
            }

            if (canRoll)
            {
                Roll(dirRoll);
            }
        }

        void InputManager()
        {
            dir.x = Input.GetAxisRaw("Horizontal");
            dir.z = Input.GetAxisRaw("Vertical");

            if (Input.GetKey(KeyCode.LeftShift))
            {
                StartCoroutine(RollCooldown());
            }
        }

        void Move(Vector3 dir)
        {
            _rb.MovePosition(_rb.position + (dir * speed * Time.fixedDeltaTime));
        }

        void Roll(Vector3 dirRoll)
        {
            isRoll = true;
        }

        #region RollCooldown

        IEnumerator RollCooldown()
        {
            isRoll = true;
            yield return new WaitForSeconds(1.0f);
            isRoll = false;
        }

        #endregion
    }
}