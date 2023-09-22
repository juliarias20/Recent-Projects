using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
    public float reloadTime;
    float reload;

    // Start is called before the first frame update
    void Awake()
    {
        reload = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        reload -= Time.deltaTime;
    }


    private void OnCollisionStay(Collision collision)
    {
       

       
        if (collision.gameObject.tag == "Player")
        {
            if(reload <= 0)
            {
                PlayerTakeDmg(10);
                reload = reloadTime;
            }
          
          
          UnityEngine.Debug.Log(GameManager.gameManager._playerHealth.Health);

            if (GameManager.gameManager._playerHealth.Health == 0)
            {
                UnityEngine.Debug.Log("Game Over");
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.dmgUnit(dmg);
      
    }

    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.healUnit(healing);

    }
}
