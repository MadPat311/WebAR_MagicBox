using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaterialChange : MonoBehaviour
{
    [SerializeField] GameObject objectModel;

    [SerializeField] GameObject infoText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        objectModel.GetComponent<TurnTranslucentThenBack>().TurnTranslucent();
        infoText.SetActive(true);
        
    }
    private void OnDisable()
    {
        objectModel.GetComponent<TurnTranslucentThenBack>().TurnBack();
        infoText.SetActive(false);
        objectModel.GetComponent<InteractionScript>().wasPlaced = true;
    }
}
