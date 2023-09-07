using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.isartdigital.Common.Moves
{
    public class MoveForward : Move
    {
        [SerializeField] private Vector3 _Direction = Vector3.right;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        protected override void Update()
        {
            if (IsOn) transform.position += _Direction.normalized * (m_Speed * Time.deltaTime);
        }
    }
}
