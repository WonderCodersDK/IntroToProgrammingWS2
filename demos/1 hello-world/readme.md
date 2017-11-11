# How to get the example on your own
1. Open Visual Studio Code (VSC)
2. Open the folder (File -> Open Folder...) that you would like to contain your small program.
    - alternatively, you can create a new folder via Windows Explorer or Finder and then right-click inside the folder and choose **Open with Code** 
3. Open the Terminal in VSC using either of these options:
    - View -> Integrated Terminal
    - On Windows, pressing Ctrl + ` (the button to the left of 1) for English keyboard, Ctrl + æ for Danish keyboard
4. Type in the Terminal
    ```
    dotnet new console -o hello-world
    cd hello-world
    dotnet run
    ```
    - **dotnet** is the .Net Core command-line interface command. Full technical documentation of what the dotnet command is capable of can be found at https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet?tabs=netcore2x (use the .Net Core 2 syntax). We use the following options of this command:
        - **new** is used to create a new application
        - **console** is the type of application to create;
        - **-o hello-world** is optional and means "create the application in a new folder named hello-world". If this part is omitted, the application will be created in the folder you are in. 
    - with **cd** you get inside the folder that was just created. Not needed, if you don't specify the ***-o*** option.
    - **dotnet run** starts the application. The application just prints "Hello World!"

    *based on: https://www.microsoft.com/net/core#windowscmd* 

# Structure of the example
- **hello-world.csproj** is used by .Net Core as a definion of the project containing the application. In this case, it simply says this is a console application.
- **Program.cs** (and any **.cs** file) is where the code for the program is written.

