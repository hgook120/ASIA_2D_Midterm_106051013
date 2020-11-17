using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

    public int count;
    public Text textcount;
    public GameObject final;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // 如果 碰到 "傳送門" 就 打開 結束選單
        if (collision.name == "Gate")
        {
            final.SetActive(true);
        }
        
        // 當碰觸的是 tag : 櫻桃 則破壞物件 並 加分
        if (collision.tag == "point")
        {
            Destroy(collision.gameObject);
            count++;
        }
    }
 }
