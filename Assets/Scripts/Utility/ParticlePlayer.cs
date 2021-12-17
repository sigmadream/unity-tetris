using UnityEngine;
using System.Collections;

public class ParticlePlayer : MonoBehaviour
{

    public ParticleSystem[] allParticles;

    void Start()
    {
        allParticles = GetComponentsInChildren<ParticleSystem>();
    }

    public void Play()
    {
        foreach (ParticleSystem ps in allParticles)
        {
            ps.Stop();
            ps.Play();
        }
    }
}
