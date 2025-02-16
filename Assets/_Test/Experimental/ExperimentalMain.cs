using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

namespace _Test.Experimental
{
    public class ExperimentalMain : UdonSharpBehaviour
    {
        [SerializeField] private RotateCube[] _cubes = null;

        private void Start()
        {
            _cubes[0].Initialize(60);
            _cubes[1].Initialize(280);
        }
    }
}