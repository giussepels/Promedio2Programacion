public abstract class MyInventarySc
{
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
