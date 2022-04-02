# agdg3
Basic anonymous forum api made with aspnet.

# How it works

After you start a server, this program will give you some endpoints. All the database will run on RAM by now.

## Get endpoints

By making a get request to `https://ip:port/agdg` you will get all the API database.  
By making a get request to `ip:port/agdg/tag` you will get all threads made into the `tag` board.  
By making a get request to `ip:port/agdg/tag/postid` you will get the thread with the id `postid` inside the `tag` board.  

## Post endpoints

# How to use

Just run `dotnet run` or build this project to create the API server.    
You can use https://github.com/ussaohelcim/agdg3-cli as the client.  

# Why

I made this just to learn the basics of aspnet.

