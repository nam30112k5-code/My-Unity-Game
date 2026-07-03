using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCoin : MonoBehaviour

{
    // Start is called before the first frame update
    private Gamemanager gamemanager;
    private void Awake()
    {
       gamemanager=FindAnyObjectByType<Gamemanager>();
    }
 
        
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            gamemanager.Addscore(1);
            
        }else if(collision.CompareTag("Trap")){
            gamemanager.gameover();

        }else if (collision.CompareTag("enemy"))
        {
            gamemanager.gameover();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
