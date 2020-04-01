using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whell : MonoBehaviour
{
	public float Motorgucu;
	public WheelCollider OnSol;
	public WheelCollider OnSag;
	public WheelCollider arkaSol;
	public WheelCollider arkaSag;
	public float donmeGucu;
	public float WhellAngleMax=20f;
	public int solabas,sagabas;
	public static int baslat;
	public GameObject buton;
    // Start is called before the first frame update
    void Awake()
    {
		solabas=0;
		sagabas=0;
		baslat=0;
		if(baslat==0)
		{
			buton.SetActive(true);
		}
	}
	public void sol()
	{
		OnSol.steerAngle=-1f*WhellAngleMax;
		OnSag.steerAngle=-1f*WhellAngleMax;
	}
	public void solcek()
	{
		OnSol.steerAngle=0f;
		OnSag.steerAngle=0f;

	}
	public void sag()
	{
		OnSol.steerAngle=+1f*WhellAngleMax;
		OnSag.steerAngle=+1f*WhellAngleMax;
	}
	public void sagcek()
	{
		OnSol.steerAngle=0f;
		OnSag.steerAngle=0f;
	}
	public void baslatfonk()
	{
		baslat=1;
		buton.SetActive(false);

	}
    // Update is called once per frame
    void Update()
    {
		if(baslat==1)
		{
		arkaSol.motorTorque=-90;
		arkaSag.motorTorque=-90;
		}

	}
}
