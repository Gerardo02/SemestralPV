using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{

	public int maxMana = 100;
	public int currentMana;
    public int ZeroMana = 100 ;

	public ManaBar ManaBar;

    // Start is called before the first frame update
    void Start()
    {
		currentMana = maxMana;
		ManaBar.SetMaxMana(maxMana);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Q))
		{
			TakeDamage(2);
		}
/*       
		if (ZeroMana <= 0)
		{
            SceneManager.LoadScene(0);
		}
*/
    }

	void TakeDamage(int damage)
	{
		currentMana -= damage;

		ManaBar.SetMana(currentMana);

		ZeroMana = currentMana;
	}
}
