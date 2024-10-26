using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace _Test.Experimental
{
    public sealed class RotateCube : UdonSharpBehaviour
    {
        private float _angle = 90f;
        private bool _isOn = true;

        public void Initialize(float angle)
        {
            _angle = angle;
        }

        private void Update()
        {
            if (_isOn)
            {
                transform.Rotate(Vector3.up, _angle * Time.deltaTime);
            }
        }

        public void Toggle()
        {
            _isOn = !_isOn;
        }
    }
}