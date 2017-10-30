using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyInventarySc
{
	public Image _imagenEquip;
	public Image [] Slots;
	public int indexImagenEquip;
	public Espadas _espadas;
	public void TipoDeEspadas (Espadas espadas)
	{
		this._espadas = espadas;
	}

	void Update ()
	{
		_imagenEquip=Slots[indexImagenEquip];
	}
}
public enum Espadas 
{
	Espada1,
	Espada2,
	Espada3,
	Espada4,
	Espada5,
	Espada6
}
