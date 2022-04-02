using agdg3.Models;
using agdg3.Services;
using Microsoft.AspNetCore.Mvc;


namespace agdg3.Controllers;
	
[ApiController]
[Route("[controller]")]
public class AgdgController: ControllerBase{
	public AgdgController(){}

	[HttpGet]
	public ActionResult<List<Board>> GetBoards() 
	{
		return AgdgService.GetBoards();
	}
	[HttpGet("{tag}")]
	public ActionResult<Board> Get(string tag)
	{
		Board board = AgdgService.GetBoard(tag);
		if(board is null) return NotFound();
		return board;
	}
	[HttpGet("{tag}/{postid}")]
	public ActionResult<Models.Thread> GetThread(string tag,int postid)
	{	
		Models.Thread t = AgdgService.GetThread(tag, postid);
		if(t is null) return NotFound();
		return t;
	}
	[HttpPost("post/")]
	public IActionResult CreateThread(IFormCollection form)
	{
		Board board = AgdgService.GetBoard(form["tag"]);
		if(board is null) return NotFound();

		AgdgService.CreateThread(board, "Anonymous", form["message"]);

		Console.WriteLine("New thread created.");
		return CreatedAtAction(nameof(CreateThread),new {},form["message"]);
	}
	[HttpPost("{tag}/{postid}")]
	public IActionResult ReplyThread(string tag,int postid,IFormCollection form)
	{
		Board board = AgdgService.GetBoard(tag);
		Models.Thread thread = AgdgService.GetThread(tag,postid);
		Reply r = new Reply(0,"Anonymous",form["message"]);

		if(board is null || thread is null) return NotFound();

		AgdgService.ReplyThread(board,thread,r);

		Console.WriteLine("New reply created.");

		return CreatedAtAction(nameof(ReplyThread),new {},form["message"]);
	}
}