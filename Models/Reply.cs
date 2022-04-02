namespace agdg3.Models{
	public class Reply{
		public int id {get;set;}
		public string name {get;set;}
		public string text {get;set;}
		public Reply(int id, string name, string text)
		{
			this.id = id;
			this.text = text;
			this.name = name;
		}
	}
}