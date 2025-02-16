using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace MasaKoha.WarldAudio
{
    public class AudioAdjustment : UdonSharpBehaviour
    {
        [SerializeField] private AudioReverbZone _audioReverbZone = null;
        [SerializeField] private TMP_InputField _roomInputField = null;
        [SerializeField] private TMP_InputField _roomHFInputField = null;
        [SerializeField] private TMP_InputField _roomLFInputField = null;
        [SerializeField] private TMP_InputField _decayTimeInputField = null;
        [SerializeField] private TMP_InputField _decayHFInputField = null;
        [SerializeField] private TMP_InputField _reflectionsInputField = null;
        [SerializeField] private TMP_InputField _reflectionsDelayInputField = null;
        [SerializeField] private TMP_InputField _reverbInputField = null;
        [SerializeField] private TMP_InputField _reverbDelayInputField = null;
        [SerializeField] private TMP_InputField _hfReferenceInputField = null;
        [SerializeField] private TMP_InputField _lfReferenceInputField = null;
        [SerializeField] private TMP_InputField _diffusionInputField = null;
        [SerializeField] private TMP_InputField _densityInputField = null;

        private int _room;
        private int _roomHF;
        private int _roomLF;
        private float _decayTime;
        private float _decayHFRation;
        private int _reflections;
        private float _reflectionsDelay;
        private int _reverb;
        private float _reverbDelay;
        private float _hfReference;
        private float _lfReference;
        private float _diffusion;
        private float _density;

        private void Start()
        {
            _room = _audioReverbZone.room;
            _roomInputField.text = _room.ToString();

            _roomHF = _audioReverbZone.roomHF;
            _roomHFInputField.text = _roomHF.ToString();

            _roomLF = _audioReverbZone.roomLF;
            _roomLFInputField.text = _roomLF.ToString();

            _decayTime = _audioReverbZone.decayTime;
            _decayTimeInputField.text = _decayTime.ToString();

            _decayHFRation = _audioReverbZone.decayHFRatio;
            _decayHFInputField.text = _decayHFRation.ToString();

            _reflections = _audioReverbZone.reflections;
            _reflectionsInputField.text = _reflections.ToString();

            _reflectionsDelay = _audioReverbZone.reflectionsDelay;
            _reflectionsDelayInputField.text = _reflectionsDelay.ToString();

            _reverb = _audioReverbZone.reverb;
            _reverbInputField.text = _reverb.ToString();

            _reverbDelay = _audioReverbZone.reverbDelay;
            _reverbDelayInputField.text = _reverbDelay.ToString();

            _hfReference = _audioReverbZone.HFReference;
            _hfReferenceInputField.text = _hfReference.ToString();

            _lfReference = _audioReverbZone.LFReference;
            _lfReferenceInputField.text = _lfReference.ToString();

            _diffusion = _audioReverbZone.diffusion;
            _diffusionInputField.text = _diffusion.ToString();

            _density = _audioReverbZone.density;
            _densityInputField.text = _density.ToString();
        }

        private void Update()
        {
            if (_audioReverbZone == null)
            {
                return;
            }

            if (int.TryParse(_roomInputField.text, out var room))
            {
                _room = room;
                _audioReverbZone.room = room;
            }

            if (int.TryParse(_roomHFInputField.text, out var roomHF))
            {
                _roomHF = roomHF;
                _audioReverbZone.roomHF = roomHF;
            }

            if (int.TryParse(_roomLFInputField.text, out var roomLF))
            {
                _roomLF = roomLF;
                _audioReverbZone.roomLF = roomLF;
            }

            if (float.TryParse(_decayTimeInputField.text, out var decayTime))
            {
                _decayTime = decayTime;
                _audioReverbZone.decayTime = decayTime;
            }

            if (float.TryParse(_decayHFInputField.text, out var decayHF))
            {
                _decayHFRation = decayHF;
                _audioReverbZone.decayHFRatio = decayHF;
            }

            if (int.TryParse(_reflectionsInputField.text, out var reflections))
            {
                _reflections = reflections;
                _audioReverbZone.reflections = reflections;
            }

            if (float.TryParse(_reflectionsDelayInputField.text, out var reflectionsDelay))
            {
                _reflectionsDelay = reflectionsDelay;
                _audioReverbZone.reflectionsDelay = reflectionsDelay;
            }

            if (int.TryParse(_reverbInputField.text, out var reverb))
            {
                _reverb = reverb;
                _audioReverbZone.reverb = reverb;
            }

            if (float.TryParse(_reverbDelayInputField.text, out var reverbDelay))
            {
                _reverbDelay = reverbDelay;
                _audioReverbZone.reverbDelay = reverbDelay;
            }

            if (float.TryParse(_hfReferenceInputField.text, out var hfReference))
            {
                _hfReference = hfReference;
                _audioReverbZone.HFReference = hfReference;
            }

            if (float.TryParse(_lfReferenceInputField.text, out var lfReference))
            {
                _lfReference = lfReference;
                _audioReverbZone.LFReference = lfReference;
            }

            if (float.TryParse(_diffusionInputField.text, out var diffusion))
            {
                _diffusion = diffusion;
                _audioReverbZone.diffusion = diffusion;
            }

            if (float.TryParse(_densityInputField.text, out var density))
            {
                _density = density;
                _audioReverbZone.density = density;
            }
        }
    }
}