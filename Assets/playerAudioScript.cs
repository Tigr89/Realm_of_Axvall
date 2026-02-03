using UnityEngine;


public class audioScript : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip playerTakeDamageLowPitch;
    public AudioClip playerTakeDamageHighPitch;

    public AudioClip playerFootSteps1;
    public AudioClip playerFootSteps2;
    public AudioClip playerFootSteps3;
    public AudioClip playerFootSteps4;
    public AudioClip playerFootSteps5;
    public AudioClip playerFootSteps6;

    public AudioClip playerAttackMelee;
    public AudioClip playerAttackBow;
    public AudioClip playerAttackSpell;
    public AudioClip playerAttackSpell2;
    public AudioClip playerGunShot;

    public AudioClip playerAttackKnifeThrow;
    public AudioClip playerAttackHeavy;
    public AudioClip playerDeathSound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            PlayRandomSound();
         
        }
    }

    void PlayDamageSound()
    {
        audioSource.clip = playerTakeDamageLowPitch;
        audioSource.Play();

        audioSource.clip = playerTakeDamageHighPitch;
        audioSource.Play();
    }
    void PlayFootsteps()
    {
        audioSource.clip = playerFootSteps1;
        audioSource.Play();

        audioSource.clip = playerFootSteps2;
        audioSource.Play();

        audioSource.clip = playerFootSteps3;
        audioSource.Play();

        audioSource.clip = playerFootSteps4;
        audioSource.Play();

        audioSource.clip = playerFootSteps5;
        audioSource.Play();

        audioSource.clip = playerFootSteps6;
        audioSource.Play();
    }

    void PlayAttackSound()
    {
        audioSource.clip = playerAttackMelee;
        audioSource.Play();

        audioSource.clip = playerAttackBow;
        audioSource.Play();

        audioSource.clip = playerAttackHeavy;
        audioSource.Play();

        audioSource.clip = playerAttackKnifeThrow;
        audioSource.Play();

        audioSource.clip = playerAttackSpell;
        audioSource.Play(); 

        audioSource.clip = playerAttackSpell2;
        audioSource.Play();

        audioSource.clip = playerGunShot;
        audioSource.Play(); 


    }
    void PlayDeathSound()
    {
        audioSource.clip = playerDeathSound;
        audioSource.Play();
    }

    void PlayRandomSound()
    {
        int random = Random.Range(0, 9);

        switch (random)
        {
            case 0:
                audioSource.PlayOneShot(playerFootSteps1);
                break;
            case 1:
                audioSource.PlayOneShot(playerFootSteps2);
                break;
            case 2:
                audioSource.PlayOneShot(playerFootSteps3);
                break;
            case 3:
                audioSource.PlayOneShot(playerFootSteps4);
                break;
            case 4:
                audioSource.PlayOneShot(playerFootSteps5);
                break;
            case 5:
                audioSource.PlayOneShot(playerFootSteps6);
                break;
            case 6:
                audioSource.PlayOneShot(playerAttackMelee);
                break;
            case 7:
                audioSource.PlayOneShot(playerAttackBow);
                break;
            case 8:
                audioSource.PlayOneShot(playerAttackHeavy);
                break;
            case 9:
                audioSource.PlayOneShot(playerAttackKnifeThrow);
                break;
        }
    }
    
}