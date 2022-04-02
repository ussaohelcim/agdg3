namespace agdg3.Models{
	public class Thread{
		public Reply OP {get;set;}
		public List<Reply> replies {get;set;}
		public Thread(Reply op)
		{
			this.OP = op;
			this.replies  = new List<Reply>();
		}
		
	}
}