using SQLite4Unity3d;

public class Plants  {

	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	public string Name { get; set; }
	
	public override string ToString ()
	{
		return string.Format ("[Plant: Id={0}, Name={1}]", Id, Name);
	}
}
