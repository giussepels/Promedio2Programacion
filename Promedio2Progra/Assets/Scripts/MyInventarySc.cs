using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.

public abstract class MyInventarySc
{
	public List <Espadas> lista;
	public Espadas _espadas;
	public void TipoDeEspadas (Espadas espadas)
	{
		this._espadas = espadas;
	}
}
public enum Espadas 
{
	EspadaDeFuego,
	EspadaDeAire,
	EspadaDeAgua
}
