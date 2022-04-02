# agdg3
Basic anonymous forum api made with aspnet.

# How it works

After you start a server, this program will give you some endpoints. All the database will run on RAM by now.

## Get endpoints

`https://ip:port/agdg` you will get all the API database.  
`ip:port/agdg/tag` you will get all threads made into the `tag` board.  
`ip:port/agdg/tag/postid` you will get the thread with the id `postid` inside the `tag` board.  


## Create a new thread

Send a form, using Post, to `https://ip:port/post/` this way:  
```
tag = "board"
message = "Hello world!"
```

## Replying to a thread

Send a form, using Post, to `https://ip:port/tag/postid` this way:
```
tag = "board"
message = "Hello world!"
```

# How to use

Just run `dotnet run` or build this project and execute it to create the API server.    
You can use https://github.com/ussaohelcim/agdg3-cli as the client.  

# Why

I made this just to learn the basics of aspnet.

