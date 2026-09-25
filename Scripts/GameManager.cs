using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject Panel;
    [SerializeField] GameObject TicTacToeText;
    [SerializeField] GameObject PlayButton;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {

        Panel.SetActive(true);

        TicTacToeText.SetActive(false);
        PlayButton.SetActive(false);

    }
}
