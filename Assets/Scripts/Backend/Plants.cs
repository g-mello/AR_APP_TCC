using SQLite4Unity3d;

public class Plants  {

	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	public string Nome_Popular { get; set; }
    public string Nome_Cientifico { get; set; }
    public string Familia { get; set; }
    public string Origem { get; set; }
    public float Altura { get; set; }
    public string Ciclo_Vida { get; set; }
    public string Substrato { get; set; }
    public string Adubo { get; set; }
    public string Periodo_Adubo { get; set; }
    public string Luminosidade { get; set; }
    public string Clima { get; set; }
    public string Qtd_Regas { get; set; }

  
    public override string ToString ()
	{
		return string.Format ("Plant ID: Id={0}," +
            " Nome Poular={1}\n " +
            " Nome_Cientifico={2}\n " +
            " Familia={3}\n " +
            " Origem={4}\n " +
            " Altura={5}\n " +
            " Ciclo_Vida={6}\n " +
            " Substrato={7}\n " +
            " Adubo={8}\n " +
            " Perido_Adubo={9}\n " +
            " Luminosidade={10}\n " +
            " Clima={11}\n " +
            " Qtd_Regas={12}\n", Id, Nome_Popular, Nome_Cientifico, Familia, Origem, Altura,
                                 Ciclo_Vida, Substrato, Adubo, Periodo_Adubo, Luminosidade,
                                 Clima, Qtd_Regas);
	}
   
}
