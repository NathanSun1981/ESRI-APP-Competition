# ESRI-APP-Competition
HoloLens APP for ESRI-APP-Competition

This is an application designed for users who are embracing the Virtual Reality (VR) world. To be more specific, an user can browse a 3D virtual Esri map with a Microsoft Hololens device (or using a HoloLens Emulator if no physical device availble). 

![HoloLens App](https://github.com/NathanSun1981/ESRI-APP-Competition/blob/master/HololensApp01.png)

A video demo can be checked from the link below: 

https://drive.google.com/file/d/1T57VUWhBEHn68JYZzMUzrviTIxz798Az/view?usp=sharing

This github repo contains source code for an experimental HoloLens mapping application developed by Esri's Prototype Lab. The original post can be found here: 

https://github.com/Esri/hololens-terrain-viewer

Built on top of the original application, this program has more new features enabled, such as voice recognition (using Microsoft .Net API) and voice control. As introduced in the video demo, a user can use voice control to change map locations (e.g. "show to 'Vancouver'") and do multiple find-place searches (e.g. "find 'sushi'", "find 'cherry blossom'"). 

# An application scenario for using this App

“This is why I live here!” exclaims many a Victoriarites during cherry blossom season. Each spring, as the rainy season fades, city dwellers pack their sweaters away and are rewarded with one of the world’s most cheerful sites: thousands of cherry trees bursting with pink and white blooms.

![Doug Clement Photography](https://github.com/NathanSun1981/ESRI-APP-Competition/blob/master/dougclementphotography.jpg)

Victoria’s many parks and gardens are ideal showcases for the beloved trees, but there are also a number of urban places to view these pink and white beauties.

1. VIEW STREET 
One of the most well-known places to view spring blossoms is along View Street in the heart of Downtown Victoria. This street is usually the first to explode in a sea of pink flowers each February/March and the nearby architecture adds an undeniable je ne sais quoi (I do not know what) to any photo!

2. BLANSHARD STREET
Find bunches of colourful cherry and plum blossoms all along Blanshard Street, from Fort Street all the way to the Parkside Hotel & Spa near St. Ann’s Academy National Historic Site.

3. BELLEVILLE STREET AT THE INNER HARBOUR
The Inner Harbour is also home to blossoming trees and flowers this time of year. Find especially bright blooms outside the Hotel Grand Pacific and The Robert Bateman Centre on the south side of the Inner Harbour.

And many many more places where you can't imagine and it always has so much fun to discover it by yourself! With our application you can just easily ask "find 'cherry blossom'" and the locations of all the cherry blossom which is showing during the blossom period within Victoria will be showing in the 3D Ersi map! We use the open data for the "tree species" from the City of Victoria to query the blossoming Prunus trees. The open data can be accessed here: 

http://opendata.victoria.ca/datasets/tree-species

# How to Run the Application
1. Check out or download the entire repository from github and install all the tools for the HoloLens environment. Make sure you have the latest update for Visual Studio 2017 and Unity and install the "Windows 10 SDK". More detailled instructions can be found here: 

https://docs.microsoft.com/en-us/windows/mixed-reality/using-visual-studio

2. Once the environment was setup successfully (might take a few hours to install the tools), open 'ESRI-APP-Competition.sln' in Microsoft Visual Studio 2017. You can either choose to run the application from the real HoloLens device if you have one or choose to run on the Hololens Emulator. 

3. Have fun and enjoy finding the cherry blossom!

![Victoria Cherry Blossom](https://github.com/NathanSun1981/ESRI-APP-Competition/blob/master/VictoriaCherryBlossom.png)


