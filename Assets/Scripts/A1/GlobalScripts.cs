using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScripts : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        AudioManagerA1.Instance.PlayBackgroundMusic(AudioManagerA1.BackgroundMusic.BackgroundMusic1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
            AudioManagerA1.Instance.PlaySoundEffect(AudioManagerA1.SoundEffect.Fire1);
        if(Input.GetButtonDown("Fire2"))
            AudioManagerA1.Instance.PlaySoundEffect(AudioManagerA1.SoundEffect.Fire2);
        if(Input.GetButtonDown("Fire3"))
            AudioManagerA1.Instance.PlaySoundEffect(AudioManagerA1.SoundEffect.Fire3);
        if(Input.GetButtonDown("Jump"))
            AudioManagerA1.Instance.PlaySoundEffect(AudioManagerA1.SoundEffect.Jump);
    }
}
