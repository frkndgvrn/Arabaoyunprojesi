using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class completed : MonoBehaviour
{  
	float timer = 0;
	public Text zaman;
	public GameObject levelx1,levelx2,level1,level2,level3,level4,level5,level6,level7,level8;
	public static int sayi=0;
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name =="target")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=1;
			whell.baslat=0;
		}
		else if(other.gameObject.name =="target1")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=2;
		}
		else if(other.gameObject.name =="target2")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=3;
		}
		else if(other.gameObject.name =="target3")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=3;
		}
		else if(other.gameObject.name =="target4")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=4;
		}
		else if(other.gameObject.name =="target5")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=5;
		}
		else if(other.gameObject.name =="target6")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=6;
		}
		else if(other.gameObject.name =="target7")
		{   
			levelx1.SetActive(false);
			levelx2.SetActive(true);
			Debug.Log("Bitti");
			sayi=7;
		}
		if(other.tag =="wall")
		{   
			Application.LoadLevel(Application.loadedLevel);

		}

	}

	void Start()
	{
		if(sayi==1)
		{
			level2.SetActive(true);
			level1.SetActive(false);
		}
		else if(sayi==2)
		{
			level3.SetActive(true);
			level1.SetActive(false);
		}
		else if(sayi==3)
		{
			level4.SetActive(true);
			level1.SetActive(false);
		}
		else if(sayi==4)
		{
			level5.SetActive(true);
			level1.SetActive(false);
		}
		else if(sayi==5)
		{
			level6.SetActive(true);
			level1.SetActive(false);
		}
		else if(sayi==6)
		{
			level7.SetActive(true);
			level1.SetActive(false);
		}
		else if(sayi==7)
		{
			level8.SetActive(true);
			level1.SetActive(false);
		}
		else
		{

		}
	}
	void Update()
	{   if(whell.baslat==1)
		{
		timer += Time.deltaTime;
		int seconds = (int)(timer % 60);
		Debug.Log(timer);
		zaman.text=seconds.ToString();
		}
	}

}
