using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _mixerGroup;
    [SerializeField] private Slider _slider;

    private bool _isOn = true;
    private float _maxVolume = 0;
    private float _minVolume = -80;
    
    public void SetVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_mixerGroup, Mathf.Log10(volume) * 20);
    }

    public void SwitchSound()
    {
        if(_isOn == true)
        {
            _isOn = false;
            _mixer.audioMixer.SetFloat(_mixerGroup, _minVolume);
        }
        else
        {
            _isOn = true;
            _mixer.audioMixer.SetFloat(_mixerGroup, _maxVolume);
        }
    }
}
