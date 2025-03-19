using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class digicode : MonoBehaviour
{
    public GameObject canvasDigicode;
    public GameObject texteDigicode;
    private bool isCanvasActive = false;
    private bool isInArea = false;
    private string code = "";
    private int cntChiffre = 0;
    public string goodCode = "";
    // Start is called before the first frame update
    void Start()
    {
        canvasDigicode.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isInArea){
            if(Input.GetKeyDown(KeyCode.E)){
                isCanvasActive = !isCanvasActive;
                canvasDigicode.SetActive(isCanvasActive);
                SetCanMovePlayer(!isCanvasActive);
			}
        }
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            isInArea = true;
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Player"){
            isInArea = false;
        }
    }

    public void PressButton(int val){
        if(cntChiffre < 3){
            cntChiffre++;
            code += val.ToString();
            texteDigicode.GetComponent<TMP_Text>().SetText(code);
            AudioManager am = AudioManager.instance;
				am.PlaySFX(am.sfx_list.sfx_bouton);
        }
    }

    public void ResetCode(){
        cntChiffre = 0;
        code = "";
        texteDigicode.GetComponent<TMP_Text>().SetText(code);
        AudioManager am = AudioManager.instance;
				am.PlaySFX(am.sfx_list.sfx_bouton);
    }

    public void EnterCode(){
        AudioManager am = AudioManager.instance;
				am.PlaySFX(am.sfx_list.sfx_bouton);
        if(code == goodCode){
            //Ajouter l'écran win
            Debug.Log("WIN");
        } else {
            ResetCode();
        }
    }

    private void SetCanMovePlayer(bool val){
        GameObject.FindWithTag("Player").GetComponent<PlayerController>().setCanMove(val);
    }
}
