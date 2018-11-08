using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Object = UnityEngine.Object;




public enum SoundEffect
{

    Jump,

}
public class AudioManager
{
    static AudioManager instance;
    // a collection of the sound effects in the game
    private Dictionary<SoundEffect, AudioClip> SoundEffects
    { get; set; }
    // Sourve for the sound effect

    private AudioSource SoundEffectSource
    {
        get; set;
    }

    // Source for BGM
    private AudioSource BGMSource
    {
        get; set;
    }

    // Singleton for AudioManager class
    public static AudioManager Instance
    { get { return instance ?? (instance = new AudioManager()); } }

    // Constructor for audiomanager
    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));

        SoundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(SoundEffectSource.gameObject);
        BGMSource = new GameObject("BGMSource", typeof(AudioSource)).GetComponent<AudioSource>();
        BGMSource.volume = .5f;
        BGMSource.loop = true;
        Object.DontDestroyOnLoad(BGMSource.gameObject);

        // ChangeBGM(Resources.Load<AudioClip>("Sound/Music/DancingMidgets"));
    }
    public void PlayOneShot(SoundEffect sound, float volumeScale = 1)
    {
        SoundEffectSource.PlayOneShot(SoundEffects[sound], volumeScale * 1);
    }
    public void changeBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }
}




