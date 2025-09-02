using UnityEngine;

public class PlayerResourceCollector : MonoBehaviour
{

    private int money = 0;
    private int wood = 0;
    private int meat = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MoneyBag"))
        {

            Destroy(collision.gameObject);
            money += 1;
            Debug.Log("Money: " + money);
        }
        if (collision.gameObject.CompareTag("Meat"))
        {

            Destroy(collision.gameObject);
            meat += 1;
            Debug.Log("Meat: " + meat);
        }
        if (collision.gameObject.CompareTag("Wood"))
        {
           
            Destroy(collision.gameObject);
            wood += 1;
            Debug.Log("Wood: " + wood);
        }
    }

}
