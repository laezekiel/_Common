using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.isartdigital.Common.Moves
{
    public class Move : MonoBehaviour
    {
        [SerializeField] protected bool m_IsOn = false; public bool IsOn { get { return m_IsOn; } set { m_IsOn = value; } }
        [SerializeField][Range(1f, 7f)] protected float m_Speed = 5f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        protected virtual void Update()
        {
        
        }
    }
}
