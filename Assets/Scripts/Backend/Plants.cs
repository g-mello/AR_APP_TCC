using SQLite4Unity3d;

public class Plants  {

	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	public string Nome_Popular { get; set; }
    public string Nome_Cientifico { get; set; }
    public string Familia { get; set; }
    public string Origem { get; set; }
    public string Altura { get; set; }
    public string Floracao { get; set; }
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
            " Floracao={6}\n " +
            " Ciclo_Vida={7}\n " +
            " Substrato={8}\n " +
            " Adubo={9}\n " +
            " Perido_Adubo={10}\n " +
            " Luminosidade={11}\n " +
            " Clima={12}\n " +
            " Qtd_Regas={13}\n", Id, Nome_Popular, Nome_Cientifico, Familia, Origem, Altura, Floracao,
                                 Ciclo_Vida, Substrato, Adubo, Periodo_Adubo, Luminosidade,
                                 Clima, Qtd_Regas);
	}
   
}
