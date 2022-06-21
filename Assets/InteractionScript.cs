using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    [SerializeField] private GameObject wholeBox; 
    [SerializeField] private GameObject brokenBox;
    [SerializeField] private GameObject magicCoin;
    [SerializeField] private GameObject stars;
    [SerializeField] private Animator _animator;
    private bool isBroken;
    public bool wasPlaced;
    private int clickCounter;

    [SerializeField] private AudioSource _audioSource;
    
    [SerializeField] private AudioClip crackingSound;
    [SerializeField] private AudioClip breakingSound;
    [SerializeField] private AudioClip magicSound;
    // Start is called before the first frame update
    void Start()
    {
        clickCounter = 0;
        isBroken = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void LateUpdate()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            if(wasPlaced)
            {
                clickCounter++;
            }
            
            if (clickCounter>0 && clickCounter <=3)
            {
                _audioSource.clip = crackingSound;
                _audioSource.volume = 0.5f;
                _audioSource.Play();
                stars.SetActive(true);
                stars.GetComponent<ParticleSystem>().Play();
            }
            
            if (clickCounter > 3)
            {
                doTheBox();
            }
        }

        
    }

    private void doTheBox()
    {
        if (isBroken)
        {
            _audioSource.clip = magicSound;
            _audioSource.volume = 1f;
            _audioSource.Play();
            wholeBox.SetActive(true);
            magicCoin.SetActive(false);
            brokenBox.SetActive(false);
            _animator.playbackTime = 0;
            isBroken = false;
            clickCounter = 0;
        }
        else
        {
            _audioSource.clip = breakingSound;
            _audioSource.volume = 1f;
            _audioSource.Play();
            isBroken = true;
            Debug.Log("Crack the box");
            wholeBox.SetActive(false);
            brokenBox.SetActive(true);
            _animator.Play("Bang",0,0.0f);
            magicCoin.SetActive(true);
            //_animator.enabled = true;    
        }
        
    }
}
