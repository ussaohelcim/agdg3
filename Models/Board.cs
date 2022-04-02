namespace agdg3.Models{
	public class Board{
		public string name {get;set;}
		public string topic {get;set;}
		public List<Thread> threads {get;set;}
		public Board(string boardName, string topic)
		{
			this.name = boardName;
			this.topic = topic;
			threads = new List<Thread>();
		}
		public void CreateThread(Thread thread)
		{
			threads.Add(thread);
		}
		
	}
}