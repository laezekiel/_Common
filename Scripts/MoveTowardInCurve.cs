using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.isartdigital.Common.Moves
{
    [RequireComponent(typeof(MoveForward))]
    public class MoveTowardInCurve : MoveToward
    {
        [SerializeField] private MoveForward _MoveForward;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        protected override void Update()
        {
            _MoveForward.IsOn = IsOn;
            base.Update();
        }
    }
}
