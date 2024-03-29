# Minecraft Building Generator for Bedrock
(This will work for Java but I am developing against Bedrock)

**CURRENT STATUS: System can now generate complete buildings and floors across all Grid Containers**

This is basic tool the uses Minecraft Functions to create Randomized Buildings, towsn,Cities, etc.

Function files are included with Minecraft Behavior packs.  This tool will accomplish the following:

* Generates Cities and Building using functions
* Creates a self exportable Behavior pack for easy installation and distribution.
* More things but I am still getting it working

### Functions
A function file can contain up to 10,000 individual commands. Leveraging this limit, this tool will generate buildings using individual commands that are auto generated by the system.

### The Grid
* Fill commands are limited to filling in 32,768 blocks
* The largest even square that can be generated is 181x181 = 32,761
* The largest perfect "Gridable" square is  13x13 = 169x169 = 28,561
* 13x13 is referred to as **Grid Square**
* 169x169 is referred to as **Grid Container**
* There are 169 Grid Squares in One Grid Container

Using this grid setup, the system generates a start and end coordinates for both a container and all of its containing squares.
Since we have all of this information now we can use this data to populate buildings on the squares.

![Grid Layout](/CityGenerator%20-%20Grid%20Layout.png?raw=true "Minecraft Generator Grid Layout")
![layout](/images/wiki/Overview_GeneratedCity_v0.1_alpha.png?raw=true "(11/29/2020) Generated Layout Overview")
![layout](/images/wiki/GeneratedCity_v0.1_alpha.png?raw=true "(11/29/2020) Generated Layout - floors")

The above screenshot is the generation of four 169x169 Grid Containers, and each container has 169 13x13 grid squares.
This grid is drawn in 4 function commands.  In the application however, every single point within this gird can be procedurally referenced allowing for any command to be executed over it. 


### Examples
(This is just some ideas nothing is concrete at this time)
* Terraforming on a large scale
* building generation: skyscrapers, custom buildings
* Extenable: Define buildings and create custom architecture.
* Adjacency: detect adjacednt grid squares and combine space for large scale buildings.


