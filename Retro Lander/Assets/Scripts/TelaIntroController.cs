//Crie um C# Script chamado TelaIntroController e aplique para o game object Canvas.
//Digite o script abaixo.
//Configure os botões Play e Sair para a funções correspondentes.
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaIntroController : MonoBehaviour
{
    public Text hudRecorde;
    public void Play(){
        SceneManager.LoadScene("Game");
    }

    public void Sair(){
        Application.Quit();
    }

    void Start() {
        if (PlayerPrefs.HasKey("RECORDE")){
            hudRecorde.text = string.Format("RECORDE: {0}", PlayerPrefs.GetInt("RECORDE"));
        }else{
            hudRecorde.text = "RECORDE: NÃO HÁ RECORDES";
        }
    }

    public void LimpaRecorde() {
        if (PlayerPrefs.HasKey("RECORDE")) {
            PlayerPrefs.DeleteKey("RECORDE");
            hudRecorde.text = "RECORDE: NÃO HÁ RECORDES";
        }
    }
}
