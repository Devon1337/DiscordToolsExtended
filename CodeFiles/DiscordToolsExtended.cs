namespace DTE {

  public DiscordToolsExtended{
    
    /*
    * Use PluginEnable() to link
    * Use PluginDisable() to Unlink
    * Use pluginMain() to determine the main method
    */
    string apiPath = @"C:/ProgramFiles/DiscordToolsExtended/Plugins";
    ArrayList pluginname = new ArrayList();
    ArrayList author = new ArrayList();
    ArrayList mainpath = new ArrayList();
    ArrayList version = new ArrayList();
      
    public String Disable(int DisCode, string pluginname) {
        switch(DisCode) {
          case 0:
            consoleDisplay("Plugin Internal Error" + "(" + pluginname + ")");
            break;
          case 1:
          default:
            
            
        }
    }
    
    public void RemovePlugin() {
      
    }
    
    public void PluginInformation(string pluginname, string author, string mainpath, int version) {
     
      pluginname.add(pluginname);
      author.add(author);
      mainpath.add(mainpath);
      version.add(version)
    }
    
    public void consoleDisplay(string Message) {
    
    console.text = Message;
    
    }
    
  
  }

}
