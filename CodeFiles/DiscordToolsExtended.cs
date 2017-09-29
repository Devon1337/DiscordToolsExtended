namespace DTE {

  public DiscordToolsExtended{
    
    /*
    * Use PluginEnable() to link
    * Use PluginDisable() to Unlink
    * Use pluginMain() to determine the main method
    */
    string apiPath = @"C:/ProgramFiles/DiscordToolsExtended/Plugins"
    string pluginname, author, mainpath;
    int version;
    
    
    
    public void PluginInformation(string pluginname, string author, string mainpath, int version) {
    
    this.pluginname = pluginname;
    this.author = author;
    this.mainpath = mainpath;
    this.version = version;
    }
    
    public void consoleDisplay(string Message) {
    
    console.text = Message;
    
    }
    
  
  }

}
