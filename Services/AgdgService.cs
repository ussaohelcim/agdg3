using agdg3.Models;

namespace agdg3.Services{
	public static class AgdgService{
		// static List<>
		static List<Board> boards;
		static int numberOfPosts;
		static AgdgService()
		{
			numberOfPosts = 0;
			Board [] initialBoards = {
				new Board("art","lets talk about 3D!"),
				new Board("code","lets talk about code"),
				new Board("enginedev","A place for all the enginechads!")
			};
			numberOfPosts++;
			initialBoards[0].CreateThread(new Models.Thread( new Reply(numberOfPosts,"Welcome to art","In this board we talk about art!")));
			numberOfPosts++;
			initialBoards[1].CreateThread(new Models.Thread( new Reply(numberOfPosts,"Welcome to code","In this board we talk about code!")));

			boards = new List<Board>();
			boards.AddRange(initialBoards);
		}
		public static Reply GetReply(int postId)
		{
			return null;
		}
		public static List<Board> GetBoards()
		{
			return boards;
		}
		public static void CreateThread(agdg3.Models.Board board, string name, string text)
		{
			numberOfPosts++;
			board.CreateThread(
				new Models.Thread(new Reply(
					numberOfPosts, name, text
				))
			);
		}
		public static void ReplyThread(Models.Board board, Models.Thread thread, Reply reply)
		{
			reply.id = ++numberOfPosts;
			thread.replies.Add(reply);
		}
		public static Board GetBoard(string url)
		{
			foreach (Board board in boards)
			{
				if(board.name.GetHashCode() == url.GetHashCode())
				{
					return board;
				}
			}
			return null;
		}
		public static Models.Thread GetThread(string boardTag, int postid)
		{
			List<Models.Thread> threads = GetBoard(boardTag).threads;
			foreach (Models.Thread thread in threads)
			{
				if(thread.OP.id == postid)
				{
					return thread;
				}
			}
			return null;
		}
	}
}