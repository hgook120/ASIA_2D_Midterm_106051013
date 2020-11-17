using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // 註解：說明
    // 按鈕如何與程式溝通
    // 需要：方法 (函式、功能) - 程式功能、演算法
    // 語法：
    // 類型 方法名稱 () {}
    // void 無類型
    public void StartGame()
    {
        print("StartGame");  // 輸出("訊息")
        SceneManager.LoadScene("Game01");
        //SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        print("QuitGame");  // 輸出("訊息")
        Application.Quit();
    }
}
