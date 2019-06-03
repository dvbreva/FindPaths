# FindPaths
This is a windows forms application that impelements a modified versions of breadth-first algorithm for searching for paths between two rooms in a building.  All you need to do is to import a .txt file that follows a specific rule and then you may proceed to test them.  

## Prerequisites 
The structure of the whole building is set to be read from a txt file. You can create your own building with as much rooms and links you want as long as you follow the rule for a single line: 
> 432, 10, 22, 4, room;  (a normal room example)   
> 400, 2, 22, 4, transit; (a transit room example)  
> 400, 432, walk, 2, yes;  (a hallway between room 400 and 432 which is bidirectional)  
> 400, 300, climb, 3, yes; (a climb between two transit rooms)  

if you want a specific link to be bidirectional - specify the ending with yes, otherwise - with no.  

## Type of links 
walk -> represents direct hallway  
climb -> represents stairs between 2 floors  
lift -> represents an elevator between 2 floors

## Type of rooms 
normal one   
transit one -> which has a climb/lift type of link and acts as a connection between two floors  

## Type of search options   
> 1st algorithm finds path with no stairs which means it avoids the "climb" type of link  
> 2nd algorithm finds the shortest path based on amount of links used  
> 3rd algorithm finds path with "lift priority" and doubles the cost of the path if climb link was used
