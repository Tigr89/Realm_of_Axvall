using UnityEngine;

public class enemyAudioScript : MonoBehaviour
{


    public AudioSource audioSource;
    public AudioClip enemyTakeDamageZombie;
    public AudioClip enemyTakeDamageDragon;
    public AudioClip enemyTakeDamageSnake;
    public AudioClip enemyTakeDamageChicken;

    
    public AudioClip enemyAttackMelee;
    public AudioClip enemyAttackKnifeThrow;

    public AudioClip enemyDeathSoundZombie;
    public AudioClip enemyDeathSoundDragon;
    public AudioClip enemyDeathSoundSnake;
    public AudioClip enemyDeathSoundChicken;

    public AudioClip enemyDragonLaugh;
    public AudioClip enemyChickenCluck;
    public AudioClip enemySnakeHiss;

    public string enemyType;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            PlayDamageSound(enemyType);
        }   
    }

    void PlayDamageSound()
    {
        audioSource.clip = enemyTakeDamageZombie;
        audioSource.Play();
        audioSource.clip = enemyTakeDamageDragon;
        audioSource.Play();
        audioSource.clip = enemyTakeDamageSnake;
        audioSource.Play();
        audioSource.clip = enemyTakeDamageChicken;

        

    }
  

    void PlayAttackSound()
    {
        audioSource.clip = enemyAttackMelee;
        audioSource.Play();



        audioSource.clip = enemyAttackKnifeThrow;
        audioSource.Play();
    }
    void PlayDeathSound()
    {
        audioSource.clip = enemyDeathSoundZombie;
        audioSource.Play();
        audioSource.clip = enemyDeathSoundDragon;
        audioSource.Play();
        audioSource.clip = enemyDeathSoundSnake;    
        audioSource.Play(); 
        audioSource.clip = enemyDeathSoundChicken; 
        audioSource.Play(); 


    }

    void enemyMisc()
    {
        audioSource.clip = enemyDragonLaugh;
        audioSource.Play(); 

        audioSource.clip = enemyChickenCluck;
        audioSource.Play();
        
        audioSource.clip = enemySnakeHiss;
        audioSource.Play(); 
    }
    void PlayDamageSound(string enemyType)
    {
       

        switch (enemyType)
        {
            case "CHICKEN":
                audioSource.PlayOneShot(enemyTakeDamageChicken);
                break;
            case "DRAGON":
                audioSource.PlayOneShot(enemyTakeDamageDragon);
                break;
            case "ZOMBIE":
                audioSource.PlayOneShot(enemyTakeDamageZombie);
                break;
            case "SNAKE":
                audioSource.PlayOneShot(enemyTakeDamageSnake);
                break;
           
        }
    }

}
