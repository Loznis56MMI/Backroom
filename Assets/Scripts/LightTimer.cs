using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTimer : MonoBehaviour
{
    private float timer = 5f;
    private bool soundPlayed = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
            if(timer < 2f && !soundPlayed){
                soundPlayed = true;
                AudioManager am = AudioManager.instance;
				am.PlaySFX(am.sfx_list.sfx_coupure);
            }
        } else {
            Destroy(gameObject);
        }
    }
}
