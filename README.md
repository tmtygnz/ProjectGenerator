# Project Generator
A simple app that will generate a starter project template
# What's new
In this first release you can create edit and delete programming language template
# Installation
Go to this [link](https://github.com/jostimian/ProjectGenerator/releases/tag/v1.0.0) and download the source code or the binary
# Usage
Run executable and make sure that the generator files is in the same folder
### Creating a new project
 - Choose your programming language

 - Choose the path for your new project

 - Click Generate

   ![Create a new proj Demo](./img/createProjDemo.gif)

   
### Adding and editing programming languages
 - Open the gen.json folder by opening the file dropdown menu and click the edit generator preferences
 - Edit the json file

| Key Name          | Value Type | What for                                                     |
| :---------------- | :--------- | :----------------------------------------------------------- |
| Language          | Array      | This is an array of objects containing templates             |
| Name              | String     | Name of the template of preferably the name of  the programming language |
| OpenCmd           | Boolean    | True = open CMD after the folders and files are created. False = don't open CMD after the folders and files are created |
| openInExplorer    | Boolean    | ****True**** = open file explorer after the folders and files are created. False = don't open file explorer  after the folders and files are  created |
| Folders           | Arrays     | Arrays of object that contains the name of the folder        |
| Folder -> dir     | String     | Name of the folder to create                                 |
| Files             | Array      | Arrays of object that contains the  name of the file and the folder |
| Files -> dir      | String     | Folder where which the file will be  created                 |
| Files -> fileName | String     | Name of the file to be created                               |

# Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

# License 

[GNU GPLv3](./License.md)

